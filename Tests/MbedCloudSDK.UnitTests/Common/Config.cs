using System;
using System.IO;
using System.Threading;
using Mbed.Cloud.Common;
using NUnit.Framework;

namespace MbedCloudSDK.UnitTests.Common
{
    [TestFixture]
    public class ConfigTests
    {
        private const string apiKey = "someApiKey";

        private const string host = "https://api.us-west-1.mbedcloud.com";

        [Test]
        public void EnvironmentVariables()
        {
            Environment.SetEnvironmentVariable(Config.API_KEY, apiKey);
            Environment.SetEnvironmentVariable(Config.HOST, host);

            var config = new Config();

            Assert.AreEqual(config.ApiKey, apiKey);
            Assert.AreEqual(config.Host, host);

            Environment.SetEnvironmentVariable(Config.API_KEY, null);
            Environment.SetEnvironmentVariable(Config.HOST, null);
        }

        [Test]
        public void EnvironmentVariablesAndBools()
        {
            Environment.SetEnvironmentVariable(Config.API_KEY, apiKey);
            Environment.SetEnvironmentVariable(Config.HOST, host);

            var config = new Config
            {
                ForceClear = true,
                AutostartNotifications = true,
            };

            Assert.AreEqual(config.ApiKey, apiKey);
            Assert.AreEqual(config.Host, host);
            Assert.AreEqual(config.ForceClear, true);
            Assert.AreEqual(config.AutostartNotifications, true);

            Environment.SetEnvironmentVariable(Config.API_KEY, null);
            Environment.SetEnvironmentVariable(Config.HOST, null);
        }

        [Test]
        public void ApiKeyAndHostPassed()
        {
            var config = new Config(apiKey, host);

            Assert.AreEqual(config.ApiKey, apiKey);
            Assert.AreEqual(config.Host, host);
        }

        [Test]
        public void AllParamsSet()
        {
            var config = new Config(apiKey, host)
            {
                ForceClear = true,
                AutostartNotifications = true,
            };

            Assert.AreEqual(config.ApiKey, apiKey);
            Assert.AreEqual(config.Host, host);
            Assert.AreEqual(config.ForceClear, true);
            Assert.AreEqual(config.AutostartNotifications, true);
        }
    }
}