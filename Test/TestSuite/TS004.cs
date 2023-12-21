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
    internal class TS004 : BaseTest
    {
        [Test]
        public void TestSuite()
        {
            TC001 tc01 = new TC001(Driver);
            TC015 tc15 = new TC015(Driver);
            TC004 tc04 = new TC004(Driver);
            TC013 tc13 = new TC013(Driver);
            TC010 tc10 = new TC010(Driver);
            TC011 tc11 = new TC011(Driver);
        }
    }
}
