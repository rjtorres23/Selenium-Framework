using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using System.Drawing;


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
        private By SignuButton = By.XPath("//button[normalize-space()='Signup']");
      

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

        public bool SignupEnterName(string u_Name)
        {
            return Helper.EnterText(SignupName, u_Name);
        }

        public bool SignupEnterEmail(string u_email)
        {
            return Helper.EnterText(SignupEmail, u_email);
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

        public string RegisterPassword(string u_pass)
        {
            
            bool success = Helper.EnterText(registerTxtPassword, u_pass);

            if (success)
            {
               
                return u_pass;
            }
            else
            {
               
                return "Failed to enter password";
            }
        }


        public bool BirthDay(string u_bday)
        {
            try
            {
                Helper.SelectOptionByText(registerDdDay, u_bday);
                return true;  // Successfully selected the option
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error selecting option: {ex.Message}");
                return false;  // Failed to select the option
            }
        }

    
        public bool ClickBirthDay()
        {
            return Helper.ClickElement(registerDdDay);
        }
        public bool BirthMonth(string u_bmonth)
        {
            return Helper.SelectOptionByText(registerDdMonths, u_bmonth);
        }
        public bool ClickBirthMonth()
        {
            return Helper.ClickElement(registerDdDay);
        }
        public bool BirthYear(string u_byear)
        {
            return Helper.SelectOptionByText(registerDdYear, u_byear);
        }
        public bool ClickBirthYear()
        {
            return Helper.ClickElement(registerDdDay);
        }

        public bool NewsLetter()
        {
            return Helper.ClickElement(registerChckNewsletter);
        }

        public bool SpecialOffers()
        {
            return Helper.ClickElement(registerChckSpecialOffers);
        }

        public bool FirstName(string u_FName)
        {
            return Helper.EnterText(registerTxtFirstName, u_FName);
        }

        public bool LastName(string u_LName)
        {
            return Helper.EnterText(registerTxtLastName, u_LName);
        }
        public bool Company(string u_company)
        {
            return Helper.EnterText(registerTxtCompany, u_company);
        }
        public bool Address1(string u_add1)
        {
            return Helper.EnterText(registerTxtAddres1, u_add1);
        }
        public bool Address2(String u_add2)
        {
            return Helper.EnterText(registerTxtAddres2, u_add2);
        }
        public bool Country(string u_country)
        {
            return Helper.SelectOptionByText(registerDdCountry, u_country);
        }
        public bool State(string u_state)
        {
            return Helper.EnterText(registerTxtState, u_state);
        }
        public bool City(string u_city)
        {
            return Helper.EnterText(registerTxtCity, u_city);
        }
        public bool ZipCode(string u_zipcode)
        {
            return Helper.EnterText(registerTxtZipCode, u_zipcode);
        }
        public bool MobileNo(string u_mobileNo)
        {
            return Helper.EnterText(registerTxtMobileNo, u_mobileNo);
        }    
        public bool BtnCreateAccount()
        {
            return Helper.ClickElement(registerBtnCreateAccnt);
        }

        

    }

}
