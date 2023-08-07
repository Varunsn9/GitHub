using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitHub.Attributes
{
   [TestClass]
    [TestCategory("Attributes")]
    public class PriorityAttributeandTestCategory
    {
        [TestMethod,TestCategory("Priority")]
        [Priority(2)]
        public void TestingPriority2()
        {
            Thread.Sleep(5000);
        }
        [TestMethod, TestCategory("Priority")]
        [Priority(1)]
        public void TestingPriority3()
        {
            Thread.Sleep(5000);
        }
        [TestMethod, TestCategory("Priority")]
        [Priority(1)]
        public void TestingPriority1()
        {
            Thread.Sleep(5000);
        }
        [TestMethod, TestCategory("Priority")]
        [Priority(0)]
        public void TestingPriority0()
        {
            Thread.Sleep(5000);
        }

    }
    [TestClass]
    [TestCategory("PriorityHashKey")]
    public class PriorityHashKeyValue
    {
        [TestMethod]
        public void D() {
            Console.WriteLine("D");
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void C()
        {
            Console.WriteLine("C");
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void B()
        {
            Console.WriteLine("B");
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void A()
        {
            Console.WriteLine("a");
            Thread.Sleep(5000);
        }
    }
    [TestClass]
    [TestCategory("PriorityValue")]
    public class PriorityValue
    {
        [TestMethod]
        [Priority(2)]
        public void D()
        {
            Console.WriteLine("D");
            Thread.Sleep(5000);
        }
        [TestMethod]
        [Priority(1)]
        public void C()
        {
            Console.WriteLine("C");
            Thread.Sleep(5000);
        }
        [TestMethod]
        [Priority(2)]
        public void B()
        {
            Console.WriteLine("B");
            Thread.Sleep(5000);
        }
        [TestMethod]
        [Priority(3)]
        public void A()
        {
            Console.WriteLine("a");
            Thread.Sleep(5000);
        }
    }
}
