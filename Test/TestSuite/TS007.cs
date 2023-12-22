﻿using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumFramework.Test.TestSuite
{
    internal class TC007 : BaseTest
    {
        [Test, Category("Smoke")]
        public void TestSuite()
        {

            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC018 tc016 = new TC018(Driver);
            TC012 tc012 = new TC012(Driver);
            TC013 tc013 = new TC013(Driver);


        }
    }
}
