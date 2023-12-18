using NUnit.Framework;
using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;

namespace SeleniumFramework.Test.TestSuite
{
    [Parallelizable(ParallelScope.Children)]
    public class TestSuite : BaseTest
    {
        [Test]
        public void TS001_Verify_login_using_vali_credentials()
        {
            // Instantiate an object of the TC005 class
            TC001 tc001 = new TC001();
            TC002 tc002 = new TC002();
            TC005 tc005 = new TC005();


            tc001.HomePage();
            tc002.Login();
            tc005.TC005_Verify_sign_up();
        }
        [Test]
        public void TS002_Verify_login_using_invalid_credentials()
        {
     
            TC001 tc001 = new TC001();
            TC003 tc003 = new TC003();
            TC004 tc004 = new TC004();

         
            tc001.HomePage();
            tc003.Singup();
            tc004.TC004_Verify_logging_in();
        }
    }
}
