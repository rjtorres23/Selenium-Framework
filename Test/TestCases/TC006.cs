
using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC006 

    {
        private IWebDriver _driver;

        public TC006(IWebDriver driver)
        {
            _driver = driver;
            TC006_RegisterUser();
        }


        [Test]
        public void TC006_RegisterUser()
        {

            Helpers helpers = new Helpers(_driver);
            SignupLoginPage signupLoginPage = new SignupLoginPage(_driver);

            //List<Data> data = helpers.JsonReader("C:\\automation\\Selenium-Framework\\Resources\\data.json");

            signupLoginPage.ClickRdMr();
            signupLoginPage.RegisterPassword();
            Thread.Sleep(1000);
            signupLoginPage.ClickBirthDay();
            signupLoginPage.BirthDay();
            Thread.Sleep(1000);
            signupLoginPage.BirthMonth();
            signupLoginPage.BirthYear();
            signupLoginPage.NewsLetter();
            signupLoginPage.SpecialOffers();
            signupLoginPage.FirstName();
            signupLoginPage.LastName();
            signupLoginPage.Company();
            signupLoginPage.Address1();
            signupLoginPage.Address2();
            signupLoginPage.Country();
            signupLoginPage.Country();
            signupLoginPage.State();
            signupLoginPage.City();
            signupLoginPage.ZipCode();
            signupLoginPage.MobileNo();
            signupLoginPage.BtnCreateAccount();


        }
    }
}
