using OpenQA.Selenium;
using SeleniumFramework.Utility;

namespace SeleniumFramework.Pages.Base
{
    public class BasePage
    {
        protected Helpers Helper { get; }

        protected BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }
    }
}

