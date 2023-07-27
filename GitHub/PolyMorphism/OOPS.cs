using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.PolyMorphism
{
    public interface OOPS
    {
        void InterfaceMethod();
        void InterfaceMethod(string name);
    }
    public abstract class FirstAbstractClass : OOPS
    {
        public abstract void InterfaceMethod();
        public virtual void InterfaceMethod(string name) 
        {
            Console.WriteLine(name);
        }
    }
    public class ConcreteClass : FirstAbstractClass
    {
        public override void InterfaceMethod()
        {
            Console.WriteLine("Implementing abstract method");
        }
        public override void InterfaceMethod(string name)
        {
            Console.WriteLine(name);
        }
    }
    [TestClass]
    public class TestClassInPolymorphism
    {
        [TestMethod]
        [TestCategory("OOPS")]
        public void TestOOPS()
        {
            OOPS concreteClass = new ConcreteClass();
            concreteClass.InterfaceMethod();
            concreteClass.InterfaceMethod("TestYantra");
        }
    }

}
