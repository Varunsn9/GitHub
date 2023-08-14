using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GitHub
{
    [TestClass]
    public class TIandTC : BaseClass
    {
        [TestInitialize]
        public void TestIni()
        {
            //   MessageBox.Show("test Initialize");
            Console.WriteLine(testContext.CurrentTestOutcome);
        }

        [TestMethod]
        public void TM1()
        {
            Console.WriteLine(testContext.CurrentTestOutcome);
            Assert.Fail();
            
        }
        [TestMethod]
        public void TM2()
        {
            Assert.IsTrue(true);
            Console.WriteLine(testContext.CurrentTestOutcome);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // MessageBox.Show("Test Cleanup");
            Console.WriteLine($" This is a test outcome {testContext.CurrentTestOutcome} ");
            if (testContext.CurrentTestOutcome.Equals(UnitTestOutcome.Passed))
            {
                Console.WriteLine($" {testContext.TestName} Test is passed");
            }
            else if(testContext.CurrentTestOutcome.Equals(UnitTestOutcome.Failed))
            {
                Console.WriteLine($" {testContext.TestName} Test is Failed");
            }
            else
            {
                Console.WriteLine($"{testContext.CurrentTestOutcome} is nither passed or failed or skipped");
            }

        }
    }
}
