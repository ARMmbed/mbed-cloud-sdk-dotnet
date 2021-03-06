"""Generates DVCS version information

requirements:


see also:
https://git-scm.com/docs/git-shortlog
https://www.python.org/dev/peps/pep-0440/
https://pypi.python.org/pypi/semver
https://pypi.python.org/pypi/bumpversion
https://github.com/warner/python-versioneer

"""
import fileinput
import os
import sys
import shlex
import subprocess
from xml.etree import ElementTree
import urllib.request
import json
import csv
import re


# Report field names in CSV
FIELDNAMES = ('PkgName', 'PkgType', 'PkgOriginator', 'PkgVersion', 'PkgSummary', 'PkgHomePageURL', 'PkgLicense', 'PkgLicenseURL', 'PkgMgrURL')

preRegex = '(?:^|\\s|"|\\()'
postRegex ='(?:$|\\s|"|\\))'

def regexp_builder(text):
	return r'{}{}{}'.format(preRegex,text,postRegex)


patterns = [
    {
		'name': 'BSD',
		'regex': [
			{ 's': regexp_builder('BSD') },
		]
	},
	{
		'name': 'GPL',
		'regex': [
			{ 's': regexp_builder('GPL'), 'flag': re.I, },
			{ 's': regexp_builder('GPLv\\d') },
		]
	},
	{
		'name': 'Public Domain',
		'regex': [
			{ 's': regexp_builder('Public domain'), 'flag': re.I }
		]
	},
	{
		'name': 'LGPL',
		'regex': [
			{ 's': regexp_builder('LGPL') },
		]
	},
	{
		'name': 'MIT',
		'regex' : [
			{ 's': '(?:^|\s)MIT(?:$|\s)' },
			{ 's': '(?:^|\s)\(MIT\)(?:$|\s)' },
		]
	},
	{
		'name': 'Apache-2.0',
		'regex': [
			{ 's': 'Apache\sLicen[cs]e', 'flag': re.I }
		]
	},
	{
		'name': 'MPL',
		'regex': [
			{ 's': regexp_builder('MPL') }
		]
	},
	{
		'name': 'WTFPL',
		'regex': [
			{ 's': regexp_builder('WTFPL') },
			{ 's': regexp_builder(
				'DO\\sWHAT\\sTHE\\sFUCK\\sYOU\\sWANT\\sTO\\sPUBLIC\\sLICEN[CS]E'
            ), 'flag': re.I }
		]
	},
	{
		'name': 'ISC',
		'regex': [
			{ 's': regexp_builder('ISC')}
		]
	},
	{
		'name': 'Eclipse Public License',
		'regex': [
			{ 's': regexp_builder('Eclipse\\sPublic\\sLicen[cs]e'), 'flag': re.I },
			{ 's': regexp_builder('EPL') },
			{ 's': regexp_builder('EPL-1\\.0') }
		]
	}
]


def identify_license(text):
    output = []
    for item in patterns:
        for regex in item['regex']:
            if re.findall(regex['s'], text, regex.get('flag', 0)):
                output.append(item['name'])
                break

    return output



def write_csv_file(output_filename, tpip_pkgs):
    """Write the TPIP report out to a CSV file.
    :param str output_filename: filename for CSV.
    :param List tpip_pkgs: a list of dictionaries compatible with DictWriter.
    """
    dirname = os.path.dirname(os.path.abspath(
        os.path.expanduser(output_filename)))

    if dirname and not os.path.exists(dirname):
        os.makedirs(dirname)

    with open(output_filename, 'w', newline='') as csvfile:
        writer = csv.DictWriter(csvfile, fieldnames=FIELDNAMES)
        writer.writeheader()
        for pkg_dict in tpip_pkgs:
            writer.writerow(pkg_dict)


def main():
    target = os.path.join(
        os.path.dirname(os.path.dirname(__file__)
                        ), 'src', 'MbedCloudSDK.csproj'
    )
    tree = ElementTree.parse(target)
    pkgs = []
    for node in tree.iter():
        packages = node.findall('PackageReference')
        for package in packages:
            if 'PrivateAssets' not in package.attrib:
                lower_name = package.attrib['Include'].lower()
                nugetInfo = urllib.request.urlopen(
                    "https://api.nuget.org/v3/registration3/" + lower_name + "/index.json").read()
                res = json.loads(nugetInfo)
                if 'items' in res:
                    first = res['items'][0]
                    if 'items' in first:
                        entry = first['items'][-1]['catalogEntry']

                        licence_text = urllib.request.urlopen(entry['licenseUrl']).read().decode('utf-8')
                        licence_type = identify_license(licence_text)

                        tpip_pkg = dict(
                            zip(FIELDNAMES, [[entry['id']], ["Nuget"], [entry['authors']], [package.attrib['Version']], [entry['title']], [entry['projectUrl']], licence_type, [entry['licenseUrl']], ["https://www.nuget.org/packages/" + entry['id']]]))

                        flattened = dict((key, '; '.join(value)) for(key, value) in tpip_pkg.items())
                        pkgs.append(flattened)

    write_csv_file('tpip.csv', pkgs)


if __name__ == '__main__':
    main()
