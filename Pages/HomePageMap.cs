using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using SeleniumFramework.Utility;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Pages
{
    public class HomePageMap(IWebDriver driver) : BasePage(driver)
    {

        //########### Element Definition #############
          
        private By SignUpLoginLink = By.XPath("//a[normalize-space()='Signup / Login']");
        private By emailAdd = By.XPath("//input[@data-qa='login-email']");
        private By password = By.XPath("//input[@placeholder='Password']");
        private By btnLogin = By.XPath("//button[normalize-space()='Login']");
        private By title = By.XPath("//img[@alt='Website for automation practice']");

        //######### Function Definition #################

        public bool isHomePageLoaded()
        {
            return Helper.IsElementVisible(title);
        }


        public bool LoginLink()
        {
            return Helper.ClickElement(SignUpLoginLink);
        }

        public bool EnterEmail()
        {
          return  Helper.EnterText(emailAdd, "sampletest@gmail.com");
        }

        public bool EnterPassword()
        {
            return Helper.EnterText(password, "pass123456");
        }

        public bool ClickBtnLogin()
        {
            return Helper.ClickElement(btnLogin);
        }

    }
}
