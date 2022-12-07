using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class DateNTimeTests
    {
        DateNTime greets = new DateNTime();

        [TestMethod()]
        public void DatentimeTest() {
            Assert.AreEqual("Good Morning", greets.Datentime());
        }
        [TestMethod()]
        public void DatentimeTest2() {
            Assert.AreEqual("Good Afternoon", greets.Datentime());
        }


    }
}