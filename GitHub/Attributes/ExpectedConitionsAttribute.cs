using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Attributes
{
    [TestClass]
    [TestCategory("Attributes")]
    public class ExpectedConitionsAttribute
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [Priority(2)]
        public void ExpectedConditionAttri()
        {
            string[] name = new string[] { "sushma", "veena", "datta", "tejas" };
            for(int i = 0; i <= name.Length; i++)
            {
                    Console.WriteLine(name[i]);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpectedConditionAttri1()
        {
            string[] name = new string[] { "sushma", "veena", "datta", "tejas" };
            for (int i = 0; i <= name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpectedConditionAttri2()
        {
            string[] name = new string[] { "sushma", "veena", "datta", "tejas" };
            for (int i = 0; i <= name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
