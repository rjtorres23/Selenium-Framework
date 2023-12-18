using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class SignupLoginPage(IWebDriver driver) : BasePage(driver)
    {
        //########### Element Definition #############


        //###########  Login  ##############
        private By SignUpLoginLink = By.XPath("//a[normalize-space()='Signup / Login']");
        private By loginEmail = By.XPath("//input[@data-qa='login-email']");
        private By loginPassword = By.XPath("//input[@placeholder='Password']");
        private By loginButton = By.XPath("//button[normalize-space()='Login']");
        private By loginAccountText = By.XPath("//h2[normalize-space()='Login to your account']");

        //###########  Sign Up  ##############
        private By SignupText = By.XPath("//h2[normalize-space()='New User Signup!']");
        private By SignupName = By.XPath("//input[@placeholder='Name']");
        private By SignupEmail = By.XPath("//input[@data-qa='signup-email']");
        private By SignuButton = By.XPath("//button[normalize-space()='Signup']]");



        //########### Function Definition #############

        public bool SignupEnterName()
        {
            return Helper.EnterText(SignupName, "Test");
        }

        public bool SignupEnterEmail()
        {
            return Helper.EnterText(SignupEmail, "TestName");
        }

        public bool SignupClick()
        {
            return Helper.ClickElement(SignuButton);
        }

        public bool LoginLink()
        {
            return Helper.ClickElement(SignUpLoginLink);
        }

        public bool isLoginEmail()
        {
            return Helper.IsElementVisible(loginEmail);
        }

        public bool isLoginPassword()
        {
            return Helper.IsElementVisible(loginPassword);
        }
        public bool isLoginButton()
        {
            return Helper.IsElementVisible(loginButton);
        }

        public bool isloginAccountText()
        {
            return Helper.IsElementVisible(loginAccountText);
        }

        public bool isSignupText()
        {
            return Helper.IsElementVisible(SignupText);
        }

        public bool isSignupName()
        {
            return Helper.IsElementVisible(SignupName);
        }
        public bool isSignupEmail()
        {
            return Helper.IsElementVisible(SignupEmail);
        }

        public bool isSignuButton()
        {
            return Helper.IsElementVisible(SignuButton);
        }





    }

}
