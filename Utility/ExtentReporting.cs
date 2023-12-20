using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Utility
{
    internal class ExtentReporting
    {
        private static ExtentReports extentReports;
        private static ExtentTest extentTest;

        private static ExtentReports StartReporting()
        {
            var path = "C:\\automation\\Selenium-Framework\\Reports\\report.html";

            if (extentReports == null)
            {
                Directory.CreateDirectory(path);

                extentReports = new ExtentReports();
                var htmlReporter = new ExtentSparkReporter(path);

                extentReports.AttachReporter(htmlReporter);
            }

            return extentReports;
        }

        public static void CreateTest(string testName)
        {
            extentTest = StartReporting().CreateTest(testName);
        }

        public static void EndReporting()
        {
            StartReporting().Flush();
        }

        public static void LogInfo(string info)
        {
            extentTest.Info(info);
        }
    }
}
