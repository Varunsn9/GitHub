using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.ExtentReportGenerate
{
    [TestClass]
    public class ReportUtility
    {
        static string testResultPath = "C:\\NewDrive\\VisualStudioRepo\\GitHub\\GitHub\\Resources\\";
        

        [TestMethod]
        [TestCategory("ExtentReportMethod")]
        public void ExtentReport()
        {
            ExtentReports extentReports = new ExtentReports();
            ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AddSystemInfo("Organization", "TestYantra");
            extentReports.AttachReporter(extentHtmlReporter);

            ExtentTest extentTest = extentReports.CreateTest("ExtentReport");
            extentTest.Log(Status.Info, "this is a info status");
            extentTest.Log(Status.Warning, "this is a warning status");
            extentTest.Info("this is a info method");
            extentTest.Fail("TestFailed");
            extentTest.Log(Status.Fatal, "This is a status Fatal");
            extentTest.Pass("TestPassed");
            ExtentTest extentTest1 = extentReports.CreateTest("new_TEST");
            extentTest1.Log(Status.Fatal, "This is a status Fatal");
            extentTest1.Pass("TestPassed");
           
            extentReports.Flush();
            extentHtmlReporter.Stop();

        }
    }
}
