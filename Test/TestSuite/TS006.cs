
﻿using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using System;



namespace SeleniumFramework.Test.TestSuite
{

    internal class TS006 : BaseTest
    {
        [Test]
        public void TestSuite()
        {

            TC001 tc001 = new TC001(Driver);
            TC004 tc004 = new TC004(Driver);
            TC018 tc016 = new TC018(Driver);
            TC012 tc012 = new TC012(Driver);
          

        }
    }
}

    


