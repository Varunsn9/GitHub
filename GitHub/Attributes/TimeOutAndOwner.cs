using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitHub.Attributes
{
    [TestClass]
    [TestCategory("Attributes")]
    
    public class TimeOutAndOwner : BaseClass
    {
        [TestMethod,TestCategory("TimeOut"),Owner("Varun")]
        [Timeout(10000)]
        public void TimeOutAttri()
        {
            Thread.Sleep(1000);
            TestContext.WriteLine(TestContext.TestName);
        }
    }
}
