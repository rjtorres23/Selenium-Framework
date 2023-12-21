
﻿using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;
using System;


namespace SeleniumFramework.Test.TestSuite
{

    internal class TS005 : BaseTest
    {
        [Test]
        public void TestSuite()
        {

            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC016 tc016 = new TC016(Driver);
            //TC007 tc007 = new TC007(Driver);
            TC008 tc008 = new TC008(Driver);

        }

    }
}
