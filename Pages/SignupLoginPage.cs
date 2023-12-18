using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;


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


        //###########  Register  ##############
        private By registerRdBtnMr = By.XPath("//input[@id='id_gender1']");
        private By registerBdBtnMrs = By.XPath("//input[@id='id_gender2']");
        private By registerTxtName = By.XPath("//input[@id='name']");
        private By registerTxtEmail = By.XPath("//input[@id='email']");
        private By registerTxtPassword = By.XPath("//input[@id='password']");
        private By registerDdDay = By.XPath("//select[@id='days']");
        private By registerDdMonths = By.XPath("//select[@id='months']");
        private By registerDdYear = By.XPath("//select[@id='years']");
        private By registerChckNewsletter= By.XPath("//input[@id='newsletter']");
        private By registerChckSpecialOffers = By.XPath("//input[@id='optin']");
        private By registerTxtFirstName = By.XPath("//input[@id='first_name']");
        private By registerTxtLastName = By.XPath("//input[@id='last_name']");
        private By registerTxtCompany= By.XPath("//input[@id='company']");
        private By registerTxtAddres1 = By.XPath("//input[@id='address1']");
        private By registerTxtAddres2 = By.XPath("//input[@id='address2']");
        private By registerDdCountry= By.XPath("//select[@id='country']");
        private By registerTxtState = By.XPath("//input[@id='state']");
        private By registerTxtCity = By.XPath("//input[@id='city']");
        private By registerTxtZipCode = By.XPath("//input[@id='zipcode']");
        private By registerTxtMobileNo = By.XPath("//input[@id='mobile_number']");
        private By registerBtnCreateAccnt = By.XPath("//button[normalize-space()='Create Account']");

        //###########  Account Created  ##############

        private By AccntCreated = By.XPath("//b[normalize-space()='Account Created!']");
        private By CreatedAccntMsgSuccess = By.XPath("//p[contains(text(),'Congratulations! Your new account has been success')]");
        private By CreatedAccntBtnContinue = By.XPath("//a[normalize-space()='Continue']");


        //########### Function Definition #############

        //Login
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

        //Signup
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

        //Register

        public bool ClickRdMr()
        {
            return Helper.ClickElement(registerRdBtnMr);
        }

        public bool RegisterPassword()
        {
            return Helper.EnterText(registerTxtPassword, "Pass123456");
        }


    }

}
