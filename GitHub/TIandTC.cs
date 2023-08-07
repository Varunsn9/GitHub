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
    public class TIandTC : BassClassCIandCU
    {
        [TestInitialize]
        public void TestIni()
        {
            MessageBox.Show("test Initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            MessageBox.Show("Test Cleanup");
        }
    }
}
