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
            TC002 tc002 = new TC002(Driver);
            TC004 tc004 = new TC004(Driver);
        }
    }
}
