using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.PolyMorphism
{
    [TestClass]
    public class dataSourceAttributeTest : BaseClass
    {

        public const string csvPath = "C:\\NewDrive\\VisualStudioRepo\\GitHub\\GitHub\\Resources\\CsvData.csv";

        [TestMethod]
        [TestCategory("DataSource"), TestCategory("CSVData"), TestCategory("Smoke")]
        [Owner("Varun")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", csvPath,
            "CsvData#csv", DataAccessMethod.Random)]
        //csvpath should be const
        public void CSVData()
        {
            Console.WriteLine(testContext.DataRow[3]);
            login(testContext.DataRow[0].ToString(), testContext.DataRow[1].ToString());
        }
        public static void login(string username,string password)
        {
            Console.WriteLine($"username is {username} and password is {password}");
        }

        public const string excelPath = "C:\\NewDrive\\VisualStudioRepo\\GitHub\\GitHub\\Resources\\VTiger.xlsx";

       
        [TestMethod]
        [TestCategory("ExcelData"), TestCategory("Regression"), TestCategory("Smoke")]
        [Owner("Varun")]
        [DataSource("System.Data.OleDb",
           "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath +
           ";Extended Properties=Excel 12.0", "LOGIN$", DataAccessMethod.Sequential)]
        //excelpath should be const
        public void ExcelData()
        {
            IWebDriver driver =new ChromeDriver();
            var username = TestContext.DataRow[2].ToString();
            var password = TestContext.DataRow["password"].ToString();
            Console.WriteLine($"username is {username} and password is {password}");
            
            Console.WriteLine(TestContext.DataRow["HOMEPAGE_TITLE"]);
            Console.WriteLine(TestContext.DataRow["HOMEPAGE_URL"]);
            
            driver.Close();
            driver.Dispose();
        }
       
    }
}
