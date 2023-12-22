using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestSuite
{
    internal class TestSuites : BaseTest
    {
        [Test, Category("Smoke")]
        public void TS001()
        {
            TC001 tc001 = new TC001(Driver);
            Thread.Sleep(2000);
            TC002 tc002 = new TC002(Driver);
        }

        [Test, Category("Regression")]
        public void TS002()
        {
            TC001 tc001 = new TC001(Driver);
            TC015 tc015 = new TC015(Driver);
            TC003 tc003 = new TC003(Driver);
            TC004 tc004 = new TC004(Driver);
        }

        [Test, Category("Smoke")]
        public void TS003()
        {
            TC015 tc015 = new TC015(Driver);
            TC003 tc003 = new TC003(Driver);
            TC005 tc005 = new TC005(Driver);
            TC006 tc006 = new TC006(Driver);
        }

        [Test, Category("Regression")]
        public void TS004()
        {
            TC001 tc01 = new TC001(Driver);
            TC015 tc15 = new TC015(Driver);
            TC004 tc04 = new TC004(Driver);
            TC013 tc13 = new TC013(Driver);
            TC010 tc10 = new TC010(Driver);
            TC011 tc11 = new TC011(Driver);
        }

        [Test, Category("Smoke")]
        public void TS005()
        {
            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC016 tc016 = new TC016(Driver);
            TC008 tc008 = new TC008(Driver);
        }

        [Test, Category("Smoke")]
        public void TS006()
        {
            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC018 tc016 = new TC018(Driver);
            TC012 tc012 = new TC012(Driver);
        }

        [Test, Category("Smoke")]
        public void TS007()
        {
            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC018 tc016 = new TC018(Driver);
            TC012 tc012 = new TC012(Driver);
            TC013 tc013 = new TC013(Driver);
        }
    }
}
