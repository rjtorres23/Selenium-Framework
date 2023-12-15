
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumFramework.Utility
{
    public class Helpers
    {
        private IWebDriver Driver { get; }
        public Helpers(IWebDriver driver)
        {
            Driver = driver;
        }

        public void HiglightElement(IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)Driver;
            jsDriver.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
        public void WaitForPageToLoad(By name, int duration = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(duration));
            wait.Until(ExpectedConditions.ElementIsVisible(name));
        }

        public void WaitForTextToBePresent(IWebElement element, string text, int duration = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(duration));
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return element;
        }
        public bool ClickElement(By locator)
        {
            try
            {
                WaitForElementVisible(locator).Click();
                return true;
            }
            catch (NoSuchElementException)
            {
                HandleError("Element not found", locator.ToString());
            }
            catch (Exception e)
            {
                HandleError("Unknown error", e.Message);
            }

            return false;
        }

        private void HandleError(string errorType, string details)
        {
            TestContext.WriteLine($"{errorType} occurred on page {Driver.Title}. Details: {details}");
        }

        public bool EnterText(By locator, string text)
        {
            try
            {
                IWebElement element = WaitForElementVisible(locator);
                element.Clear(); // Clear any existing text
                element.SendKeys(text); // Enter the new text
                return true;
            }
            catch (NoSuchElementException)
            {
                HandleError("Element not found", locator.ToString());
            }
            catch (Exception e)
            {
                HandleError("Unknown error", e.Message);
            }

            return false;
        }




        public IWebElement LocateElement(Locators type, string name)
        {
            return type switch
            {
                Locators.Xpath => Driver.FindElement(By.XPath(name)),
                Locators.CssSelector => Driver.FindElement(By.CssSelector(name)),
                Locators.ID => Driver.FindElement(By.Id(name)),
                Locators.Name => Driver.FindElement(By.Name(name)),
                Locators.LinkText => Driver.FindElement(By.LinkText(name)),
                Locators.ClassName => Driver.FindElement(By.ClassName(name)),
                Locators.PartialLinkText => Driver.FindElement(By.PartialLinkText(name)),
                Locators.TagName => Driver.FindElement(By.TagName(name)),
                _ => throw new ArgumentOutOfRangeException(type.ToString(), $"Invalid Type, {type.ToString()}")
            };
        }

        public IList<IWebElement> LocateElements(Locators type, string name)
        {
            return type switch
            {
                Locators.Xpath => Driver.FindElements(By.XPath(name)),
                Locators.CssSelector => Driver.FindElements(By.CssSelector(name)),
                Locators.ID => Driver.FindElements(By.Id(name)),
                Locators.Name => Driver.FindElements(By.Name(name)),
                Locators.LinkText => Driver.FindElements(By.LinkText(name)),
                Locators.ClassName => Driver.FindElements(By.ClassName(name)),
                Locators.PartialLinkText => Driver.FindElements(By.PartialLinkText(name)),
                Locators.TagName => Driver.FindElements(By.TagName(name)),
                _ => throw new ArgumentOutOfRangeException(type.ToString(), $"Invalid Type, {type.ToString()}")
            };
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public string GetTitle()
        {
            return Driver.Title;
        }

        public void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }
     
    }
}