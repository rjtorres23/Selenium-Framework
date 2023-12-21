﻿using NUnit.Framework;
using SeleniumFramework.Test.TestCases;
using SeleniumFramework.TestCases.Base;
using SeleniumFramework.Utility;

namespace SeleniumFramework.Test.TestSuite
{

    public class TS001 : BaseTest
    {
        [Test]
        public void TestSuite()
        {
            // Instantiate an object of the TC005 class
            TC001 tc001 = new TC001(Driver);
           // Thread.Sleep(2000);
            ExtentReporting.LogInfo("After TC001");
           // TC002 tc002 = new TC002(Driver);
            TC005 tc005 = new TC005(Driver);
            TC006 tc006 = new TC006(Driver);
        }

    }
}
