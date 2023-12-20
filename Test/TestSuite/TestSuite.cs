using NUnit.Framework;
using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;

namespace SeleniumFramework.Test.TestSuite
{
    [Parallelizable(ParallelScope.Children)]
    public class TestSuite : BaseTest
    {
        [Test]
        public void TS001_Verify_login_using_vali_credentials()
        {
            // Instantiate an object of the TC005 class
            TC001 tc001 = new TC001(Driver);
            Serilog.Log.Debug("After tc001");
            //ExtentReporting.LogInfo("After tc001");
            TC002 tc002 = new TC002(Driver);
            TC005 tc005 = new TC005(Driver);
        }
    }
}
