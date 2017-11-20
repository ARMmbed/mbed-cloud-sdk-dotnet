#!/bin/sh

BACKEND_URL="http://localhost:3000";
export PYTHONPATH="TestServer/testrunner";

cleanup() {
  curl -X GET http://localhost:3000/_exit
  echo "Test run finished. Cleaning up";
}

is_running() {
  if ps -p $1 >/dev/null; then
    return 0;
  fi
  return 1;
}

# Ensure we have API key
API_KEY="${MBED_CLOUD_API_KEY}"
if [ -z $API_KEY ]; then
  >&2 echo "API Key needs to be set using MBED_CLOUD_API_KEY env var";
  exit 1;
fi

# Start the Python SDK test backend server. Send to background.
mono --debug --profile=log:coverage,covfilter=+[MbedCloudSDK],output=int-output.mlpd TestServer/bin/Release/TestServer.exe $API_KEY

sleep 2

# Start the test runner
python TestServer/testrunner/bin/trunner -s $BACKEND_URL -k $API_KEY
RET_CODE=$?

cleanup

exit $RET_CODE