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
        private By txtSubscription = By.XPath("//h2[normalize-space()='Subscription']");
        private By arrowUp = By.XPath(" //i[@class='fa fa-angle-up']");
       
        //######### Function Definition #################

        public bool isHomePageLoaded()
        {
            return Helper.IsElementVisible(title);
        }


        public bool LoginLink()
        {
            return Helper.ClickElement(SignUpLoginLink);
        }

        public bool EnterEmail(string u_username)
        {
          return  Helper.EnterText(emailAdd, u_username);
        }

        public bool EnterPassword(string u_password)
        {
            return Helper.EnterText(password, u_password);
        }

        public bool ClickBtnLogin()
        {
            return Helper.ClickElement(btnLogin);
        }

        public bool isSubscription()
        {
            return Helper.IsElementVisible(txtSubscription);
        }

        public bool ClickUp()
        {
            return Helper.ClickElement(arrowUp);
        }

    }
}
