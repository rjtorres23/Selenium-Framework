﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json;

namespace SeleniumFramework.Utility
{
    public class Helpers
    {
        private IWebDriver Driver { get; }
        public Helpers(IWebDriver driver)
        {
            Driver = driver;
        }

        //*********** Element Interaction  ***********
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

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

    

        public bool IsElementVisible(By locator)
        {
            bool returnValue = false;
            try
            {
                returnValue = WaitForElementVisible(locator).Displayed;
            }
            catch (NoSuchElementException e)
            {
                TestContext.WriteLine("Element " + locator + "not found on page " + Driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                TestContext.WriteLine("Unknown error " + e.Message + " occurred on page " + Driver.Title);
                returnValue = false;
            }
            return returnValue;
        }

        public void CaptureScreenshot(string testName, string stepNo)
        {
            try
            {
                // Specify the base directory for saving screenshots
                string baseDir = @"C:\Automation\Selenium-Framework\Reports";
                Console.WriteLine($"Base Screenshot directory: {baseDir}");

                // Create a subfolder for the run result date inside the "Reports" folder
                string runResultDir = Path.Combine(baseDir, $"RunResult_{DateTime.Now:yyyyMMdd}");
                Console.WriteLine($"Run Result directory: {runResultDir}");

                // Check if the run result directory exists, and create it if not
                if (!Directory.Exists(runResultDir))
                    Directory.CreateDirectory(runResultDir);

                // Create a subfolder for the "Screenshots" folder inside the run result directory
                string screenshotsDir = Path.Combine(runResultDir, "Screenshots");
                Console.WriteLine($"Screenshots directory: {screenshotsDir}");

                // Check if the screenshots directory exists, and create it if not
                if (!Directory.Exists(screenshotsDir))
                    Directory.CreateDirectory(screenshotsDir);

                // Create a subfolder for the specific test case within the screenshots directory
                string testDir = Path.Combine(screenshotsDir, testName);
                Console.WriteLine($"Test Screenshot directory: {testDir}");

                // Check if the test case directory exists, and create it if not
                if (!Directory.Exists(testDir))
                    Directory.CreateDirectory(testDir);

                // Capture a screenshot using the WebDriver
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();

                // Define the file path for the screenshot within the test case folder
                string imageFilePath = Path.Combine(testDir, $"{testName}_Step{stepNo}_{GetTimestamp(DateTime.Now)}.png");

                // Write the screenshot bytes directly to the file
                File.WriteAllBytes(imageFilePath, ss.AsByteArray);

                // Attach the screenshot file path to the test report
                TestContext.AddTestAttachment(imageFilePath);

                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturing screenshot: {ex.Message}");
                // Log the exception or handle it as appropriate for your testing framework
            }
        }


        public void ScrollToElementUsingJavaScript(IWebDriver driver, IWebElement element)
        {
            /*
             * If this method is not working for you, use following code
             * ((JavascriptExecutor) driver).executeScript("arguments[0].scrollIntoView(true);", element);
             */
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoViewIfNeeded()", element);

        }

        public void ScrollDown(IWebDriver driver, int pixelsToScroll)
        {
         
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollBy(0, {pixelsToScroll});");
        }
   

        public void SelectOptionByText(IWebElement dropdownElement, string text)
        {
            SelectElement dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByText(text);
        }

    

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public string GetTitle(By title)
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

        internal static void ScrollToBottom()
        {
            throw new NotImplementedException();
        }

        public List<Data> JsonReader(string path)
        {
            var serializer = new JsonSerializer();
            List<Data> data = new();
            using (var reader = new StreamReader(path))
                using (var  jsonReader = new JsonTextReader(reader))
            {
                data = serializer.Deserialize<List<Data>>(jsonReader);
            }

            return data;
        }

        internal bool SelectOptionByText(By registerDdDay, string v)
        {
            throw new NotImplementedException();
        }
    }

    public class Data
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string Birthday { get; set; }
        public string Birthdate { get; set; }
        public string Birthyear { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Compamy { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string MobileNo { get; set; }



    }

    
}