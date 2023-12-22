using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestSuite
{
    internal class TS002 : BaseTest
    {
        [Test, Category("Regression")]
        public void TestSuite()
        {
            TC001 tc001 = new TC001(Driver);
            TC015 tc015 = new TC015(Driver);
            TC003 tc003 = new TC003(Driver);         
            TC004 tc004 = new TC004(Driver);
        }
    }
}
