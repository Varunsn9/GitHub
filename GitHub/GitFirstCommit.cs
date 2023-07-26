using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    public class GitFirstCommit
    {
        public virtual void Show()
        {
            Console.WriteLine("this is the show method in Parent class");
        }
        public virtual void Show1()
        {
            Console.WriteLine("this is the show1 method in Parent class");
        }
    }
    [TestClass]
    public class ChildClass : GitFirstCommit
    {
        public override void Show()
        {
            Console.WriteLine("this is the show method in Child class");
        }
        public override void Show1()
        {
            Console.WriteLine("this is the show1 method in Child class");
        }
        public static void Main(string[] args)
        {
            
            GitFirstCommit gt=new ChildClass();
            gt.Show();
            
            gt.Show1();

        }
        [TestMethod]
        public void TEst()
        {
            
            GitFirstCommit gt = new ChildClass();
            gt.Show();
            gt.Show1();

        }
    }
}
