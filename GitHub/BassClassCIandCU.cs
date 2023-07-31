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
    public class BassClassCIandCU
    {
        [ClassInitialize]
        public static void ClassINi(TestContext testContext)
        {
            MessageBox.Show("this is a class INitialize");
        }
        [TestMethod]
        [TestCategory("ClassINi")]
        public void Display()
        {
            MessageBox.Show("This is a testmethod");
        }
      
        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("This is Class Cleanup");
        }
    }
}
