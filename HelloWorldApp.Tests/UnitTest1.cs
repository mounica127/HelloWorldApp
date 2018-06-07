using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Http;
using HelloWorldApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloWorldController controller = new HelloWorldController();
            IEnumerable<string> details = controller.Get().ToList();
            var value = details[0];
            Assert.AreEqual(value, "Hello World");
        }
    }
}
