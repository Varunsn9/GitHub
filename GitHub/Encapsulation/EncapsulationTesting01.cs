using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Encapsulation
{
    public class EncapsulationTesting01
    {
        private string show;
        public string Show
        {
            get { return show; }
            set { show = value; }
        }
        public string display { get; set; }        
    }

    [TestClass]
    public class IMplementationOfEncapsulation : EncapsulationTesting01
    {

        [TestMethod]
        [TestCategory("Encapsulation")]
        public void Encapsulation()
        {
            Console.WriteLine(Show);
            Show = "TestYantra";
            Console.WriteLine(Show);

            Console.WriteLine("======================================");

            Console.WriteLine(display);
            display = "Tyss";
            Console.WriteLine(display);
        }

    }
}
