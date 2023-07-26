using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.PolyMorphism
{
    public class ThisAndBase
    {
        public string a = "ParentClass";
       public ThisAndBase() 
        {
            Console.WriteLine("this is a constructor from parentclass");
        }
        public ThisAndBase(string name)
        {
            Console.WriteLine("this is a constructor from parentclass with Parameter");
        }

    }
    public class SubClassInsidePolymorhipsm : ThisAndBase
    {
        public string a = "subClass";
        public SubClassInsidePolymorhipsm() : base("Tyss")
        {
            Console.WriteLine("This is the constuctor form sub class");
        }
       
        public SubClassInsidePolymorhipsm(string value) : this()
        {
            //Console.WriteLine(a);
            Console.WriteLine(base.a);
            Console.WriteLine(this.a);
            Console.WriteLine("this is a constructor with string argument");
        }

    }
    public class BaseClassA
    {
        public int a = 3;
    }
    [TestClass]
    public class ExecutionClass : BaseClassA
    {
        public ExecutionClass()
        {
            Console.WriteLine("ExecutionClass Constructor");
        }
        public int a = 0;
        [TestMethod]
        [TestCategory("ThisAndBase")]
        public void TestIngThisAndBase() 
        {
            int a = 1;
            base.a=a;

            Console.WriteLine(base.a);
            SubClassInsidePolymorhipsm subClassInsidePolymorhipsm = new SubClassInsidePolymorhipsm("value");

        }
    }
}
