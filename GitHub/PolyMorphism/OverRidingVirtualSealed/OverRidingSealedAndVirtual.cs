using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.PolyMorphism.OverRidingVirtualSealed
{
    abstract class OverRidingSealedAndVirtual
    {
        public abstract void AbstractMethod();
        public virtual void VirtualMethod()
        {
            Console.WriteLine("This is a Virtual Method");
        }
    }

     class SubClass : OverRidingSealedAndVirtual
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Overriding the abstract method");
        }
        public sealed override void VirtualMethod()// we cannot override this method because it is sealed
        {
            Console.WriteLine("Overriding and Sealing the virtual  Method");
        }
    }
     class MainClass : SubClass
    {
        public sealed override void AbstractMethod()
        {
            Console.WriteLine("sealed override of abstract method");
        }
       
        public static void Main()
        {
            
        }
    }
}
