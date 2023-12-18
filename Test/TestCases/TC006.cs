
using SeleniumFramework.Pages;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using OpenQA.Selenium;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC006 : BaseTest

    {

        [Test]
        public void RegisterUser()
        {
            SignupLoginPage signupLoginPage = new SignupLoginPage(Driver);


        }
    }
}
