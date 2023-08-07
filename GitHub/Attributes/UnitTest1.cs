using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GitHub.Attributes
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
