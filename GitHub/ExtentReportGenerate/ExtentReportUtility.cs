using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.ExtentReportGenerate
{
    [TestClass]
    public class ExtentReportUtility
    {
        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public ExtentTest extentTest;
        public string screenShotPath;
        public static string testResultPath = "C:\\NewDrive\\VisualStudioRepo\\GitHub\\GitHub\\Resources\\";
        public static ExtentHtmlReporter extentHtmlReporter;
        public static TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [AssemblyInitialize]
        public static void AssemblyIniTializeMethod(TestContext testContext)
        {
            extentReports = new ExtentReports();
            // instance.ExtendReportInitilize();
           // Console.WriteLine("codeIni");
            extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AddSystemInfo("Organization", "TestYantra");
            extentReports.AddSystemInfo("OS", "Windows 10");
            extentReports.AddSystemInfo("Browser", "Chrome");
            
            extentReports.AttachReporter(extentHtmlReporter);
        }

        [ClassInitialize]
        public static void ClassInitilize(TestContext testContext)
        {
            driver = new ChromeDriver();
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Close();
            driver.Dispose();
        }

        [TestInitialize]
        public void ExtentReportsMethod()
        {
            // extentTest = extentReports.CreateTest("TestInilize");
            //driver = new ChromeDriver();
            extentTest = extentReports.CreateTest(TestContext.TestName);
        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void Facebook()
        {
            //extentTest = extentReports.CreateTest("Facebook");

            driver.Navigate().GoToUrl("https://www.facebook.com");

            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = testResultPath + TestContext.TestName + ".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Info, "facebook taking a screenshot");

            bool condition = true;
            if (condition == true)
            {
                Assert.IsTrue(true);
                extentTest.Pass("TestPassed");
            }
            else
            {
                extentTest.Fail("TestFailed");
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void Google()
        {
            //extentTest = extentReports.CreateTest("Google");
            driver.Navigate().GoToUrl("https://www.google.com");
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = testResultPath + TestContext.TestName + ".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Warning, "Its is a status Waring");
            extentTest.Warning("ExtentTestWarning Method");
            Assert.IsTrue(true);
            extentTest.Pass("TestPassed");

        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("Facebook", "https://www.facebook.com", true)]
        [DataRow("Google", "https://www.google.com", true)]
        [DataRow("Vtiger", "https://www.flipkart.com", true)]
        [TestCategory("ExtentHtmlReporter")]
        public void DataDriven(string website, string url, bool test)
        {
            //extentTest = extentReports.CreateTest("Facebook");

            driver.Navigate().GoToUrl(url);

            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = testResultPath + TestContext.TestName + " " + website + ".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Info, TestContext.TestName + " " + website + " taking a screenshot");

            bool condition = test;
            if (condition == true)
            {
                Assert.IsTrue(true);
                extentTest.Pass("TestPassed");
            }
            else
            {
                extentTest.Fail("TestFailed");
                Assert.IsTrue(false);

            }
        }

        [TestCleanup]
        public void ExtentReportTearDown()
        {
            Console.WriteLine(TestContext.CurrentTestOutcome);
            extentTest.AddScreenCaptureFromPath(screenShotPath);

        }

        [AssemblyCleanup]
        public static void AssemblyCleanUpMethod()
        {
            //instance.ExtendReportCleanup();
            extentReports.Flush();
            Console.WriteLine("cleanup");
            extentHtmlReporter.Stop();
        }
    }
}
