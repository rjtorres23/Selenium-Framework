using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using SeleniumFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    internal class CommonPage(IWebDriver driver) : BasePage(driver)
    {
        private By home = By.XPath("//a[normalize-space()='Home']");
        private By signup = By.XPath("//a[normalize-space()='Signup / Login']");
        private By contactUs = By.XPath("//a[normalize-space()='Contact us']");
        private By testCase = By.XPath("//a[contains(text(),'Test Cases')]");
        private By products = By.XPath("//a[@href='/products']");
        private By logout = By.XPath("//a[normalize-space()='Logout']");

        public bool clickHome()
        {
            return Helper.ClickElement(home);
        }

        public bool clickSignup()
        {
            return Helper.ClickElement(signup);
        }

        public bool clickContactUs()
        {
            return Helper.ClickElement(contactUs);
        }

        public bool clickTestCase()
        {
            return Helper.ClickElement(testCase);
        }

        public bool clickProducts()
        {
            return Helper.ClickElement(products);
        }

        public bool clickLogout()
        {
            return Helper.ClickElement(logout);
        }
    }
}
