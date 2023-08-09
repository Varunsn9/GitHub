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
    //[TestCategory("Inilization and Cleanup")]
    public class TestMethodForINandCU :BaseClass
    {
        [TestMethod]
        [TestCategory("Inilization and Cleanup")]
        public void TestMethod()
        {
          //  MessageBox.Show("This is a test method",TestContext.TestName);
           // MessageBox.Show(TestContext.Properties["Browser"].ToString());
        }

        [ClassInitialize]
        public static new void ClassINi(TestContext testContext)
        {
            //MessageBox.Show("this is a class INitialize");
        }

        [ClassCleanup]
        public static new void ClassCleanup()
        {
            //MessageBox.Show("This is Class Cleanup");
        }

    }
}
