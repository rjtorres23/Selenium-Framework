
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumFramework.Base
{
    internal class Factory
    {
        internal IWebDriver CreateBrowser(Network type, BrowserType name)
        {
            switch (type)
            {
                case Network.Local:
                    return CreateLocalBrowser(name);
                case Network.Remote:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), $"No such network type {type}");
            }
        }

        private IWebDriver CreateLocalBrowser(BrowserType name)
        {
            switch (name)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.Edge:
                    return new EdgeDriver();
                case BrowserType.Firefox:
                    return GetFirefoxDriver();
                default:
                    throw new ArgumentOutOfRangeException(nameof(name), $"No such browser {name}");
            }
        }

        private IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(options);
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(options);
        }
    }
}

