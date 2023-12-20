using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Pages;
using SeleniumFramework.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;
using Serilog.Core;
using Serilog.Events;
using Serilog;

namespace SeleniumFramework.TestCases.Base
{
    public class BaseTest
    {
        public required IWebDriver Driver { get; set; }
        static ConfigSetting config;
        static string configPath = "C:\\automation\\Selenium-Framework\\Resources\\config.json";


        [SetUp]
        public void TestSetup()
        {
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);

            config = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configPath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);

          /* LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().
                MinimumLevel.ControlledBy(levelSwitch).
                WriteTo.File("C:\\automation\\Selenium-Framework\\Reports\\Logs\\",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {Newline}",
                rollingInterval: RollingInterval.Day).CreateLogger();

            Log.Information("Sample");*/

            var factory = new Factory();

            if (config.Browser.ToLower() == "chrome")
            {
                Driver = factory.CreateBrowser(Network.Local, BrowserType.Chrome);
            }
            else if (config.Browser.ToLower() == "edge")
            {
                Driver = factory.CreateBrowser(Network.Local, BrowserType.Edge);
            }
            else if (config.Browser.ToLower() == "firefox")
            {
                Driver = factory.CreateBrowser(Network.Local, BrowserType.Firefox);
            }

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://automationexercise.com/");
        }

        [TearDown]
        public void TestEnding()
        {
            EndTest();
            ExtentReporting.EndReporting();
            Driver.Close();
            Driver.Quit();
        }

        private static void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case NUnit.Framework.Interfaces.TestStatus.Failed:
                    ExtentReporting.LogInfo($"Test has failed {message}");
                    break;
                case NUnit.Framework.Interfaces.TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            ExtentReporting.LogInfo("END TEST");
        }
    }
}
