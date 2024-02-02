
using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;

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

        public void TC006_RegisterUser()
        {

            Helpers helpers = new Helpers(_driver);
            SignupLoginPage signupLoginPage = new SignupLoginPage(_driver);

            List<Data> data = helpers.JsonReader("C:\\automation\\Selenium-Framework\\Resources\\data.json");
            
            signupLoginPage.ClickRdMr();
            string enterPassword = signupLoginPage.RegisterPassword(data[0].Password);
            ExtentReporting.LogInfo($"Input Password: {enterPassword}");
            Thread.Sleep(1000);
            signupLoginPage.ClickBirthDay();    
            bool selectBirthday = signupLoginPage.BirthDay("4");
            Thread.Sleep(1000);
            signupLoginPage.ClickBirthMonth();
            bool enterBirthMonth = signupLoginPage.BirthMonth(data[0].Birthdate);
            Thread.Sleep(1000);
            signupLoginPage.ClickBirthYear();
            bool SelectBirthYear = signupLoginPage.BirthYear(data[0].Birthyear);
            signupLoginPage.NewsLetter();
            signupLoginPage.SpecialOffers();
            bool enterFirtName = signupLoginPage.FirstName(data[0].FirtName);
            bool enterLastName = signupLoginPage.LastName(data[0].LastName);
            bool enterComoany = signupLoginPage.Company(data[0].Compamy);
            bool enterAddress1 = signupLoginPage.Address1(data[0].Address1);
            bool enterAddress2 = signupLoginPage.Address1(data[0].Address2);
            bool enterCountry = signupLoginPage.Country(data[0].Country);
            bool enterState = signupLoginPage.State(data[0].State);
            bool enterCity = signupLoginPage.City(data[0].City);
            bool enterZipCode = signupLoginPage.ZipCode(data[0].Zipcode);
            bool enterMobileNo = signupLoginPage.MobileNo(data[0].MobileNo);
            signupLoginPage.BtnCreateAccount();

            Assert.Multiple(() =>
            {
                // Add  assertions 
                ExtentReporting.LogInfo($"Password Assertion: {enterPassword}");
                Assert.That(enterPassword, Is.EqualTo("pass123456"));
                ExtentReporting.LogInfo($"Birthday Assertion: {selectBirthday}");
                Assert.That(selectBirthday, Is.True, "Birthday is Visible.");
                ExtentReporting.LogInfo($"BirthMonth Assertion: {enterBirthMonth}");
                Assert.That(enterBirthMonth, Is.True, "BirthMonth is visible.");
                Assert.That(SelectBirthYear, Is.True, "BirthYear is visible.");
                Assert.That(enterFirtName, Is.True,   "FirstName is visible.");
                Assert.That(enterLastName, Is.True,   "LastName is visible.");
                Assert.That(enterComoany, Is.True,   "Company is visible");
                Assert.That(enterAddress1, Is.True, "Address1 is visible.");
                Assert.That(enterAddress2, Is.True, "Address2 is visible.");
                Assert.That(enterCountry, Is.True, "Country is visible.");
                Assert.That(enterState, Is.True, "State is visible.");
                Assert.That(enterCity, Is.True, "City is visible.");
                Assert.That(enterZipCode, Is.True, "ZipCode is visible.");
                Assert.That(enterMobileNo, Is.True, "MObileNO is vivsble.");

            });


        }
    }
}
