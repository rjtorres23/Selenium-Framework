using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace SeleniumFramework.Utility
{
    internal class ExtentReporting
    {
        private static ExtentReports extentReports;
        private static ExtentTest extentTest;

        private static ExtentReports StartReporting()
        {
            if (extentReports == null)
            {
                string baseDir = @"C:\automation\Selenium-Framework\Reports";
                string runResultFolderPath = Path.Combine(baseDir, $"RunResult_{DateTime.Now:yyyyMMdd}");
                string htmlFolderPath = Path.Combine(runResultFolderPath, "HTML");

                string name = DateTime.Now.ToString("HHmmss");
                string reportFileName = $"report_{name}.html";
                string reportFilePath = Path.Combine(htmlFolderPath, reportFileName);

                Directory.CreateDirectory(runResultFolderPath);
                Directory.CreateDirectory(htmlFolderPath);

                extentReports = new ExtentReports();
                var sparkReporter = new ExtentSparkReporter(reportFilePath);

                extentReports.AttachReporter(sparkReporter);
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
