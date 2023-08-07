using GitHub.ExtentReportGenerate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Attributes.INIandCle
{
    //[TestClass]
    public class Classinicle : ExtentReportUtility
    {
        [ClassInitialize]
        public static void ClassINi(TestContext _testContext)
        {
            testContext.WriteLine("ClassINi");
        }
        [ClassCleanup]
        public static void ClassCleanup() 
        {
            testContext.WriteLine("Classcle");
        }
        [TestMethod]
        [TestCategory("inicle")]
        public void ClassinicleTest()
        {
            testContext.WriteLine("TestMethod");
            //driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
        [TestInitialize]
        public void TestInitialize()
        {
            testContext.WriteLine("TestINi");
        }
        [TestCleanup]
        public static void TestCleanup()
        {
            testContext.WriteLine("TestCleanup");
        }
    }
}
