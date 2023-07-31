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
    public class BaseClass
    {
        [AssemblyInitialize]
        public static void AssemblyIni(TestContext testContext)
        {
            MessageBox.Show("This is AssemblyInitialize");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("This is AssemblyCleanUp");
        }
    }
}
