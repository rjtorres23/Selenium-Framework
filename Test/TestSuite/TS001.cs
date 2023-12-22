using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;

namespace SeleniumFramework.Test.TestSuite
{

    public class TS001 : BaseTest
    {
        [Test, Category("Smoke")]
        public void TestSuite()
        {
       
            TC001 tc001 = new TC001(Driver);
            Thread.Sleep(2000);
            TC002 tc002 = new TC002(Driver);
       
        }

    }
}
