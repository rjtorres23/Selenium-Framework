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
    internal class TS003 : BaseTest
    {
        [Test]
        public void TestSuite()
        {
            TC015 tc015 = new TC015(Driver);
            TC003 tc003 = new TC003(Driver);
            TC005 tc005 = new TC005(Driver);
            TC006 tc006 = new TC006(Driver);
        }
    }
}
