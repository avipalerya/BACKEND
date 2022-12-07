using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class TestDrivenTests

    {
        TestDriven shape = new TestDriven();
        [TestMethod()]
        public void CircumferenceTest()
        {
            Assert.AreEqual(30, shape.Circumference(5));
        }
        [TestMethod()]
        public void AreaOfTriangleTest()
        {
            Assert.AreEqual(12, shape.AreaOfTriangle(5, 5));
        }

        [TestMethod()]
        public void AreaOfRectangleTest()
        {
            Assert.AreEqual(10,shape.AreaOfRectangle(2,5));
        }
    }
}

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class TestDrivenTests
    {
        TestDriven testdriven = new TestDriven();

        [TestMethod()]
        public void ProductTest()
        {
            Assert.AreEqual(25, testdriven.Product(5, 5));
        }
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(10, testdriven.add(5, 5));
        }
        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(0, testdriven.sub(5, 5));
        }
        [TestMethod()]
        public void DivTest()
        {
            Assert.AreEqual(1, testdriven.div(5, 5));
        }
    }
}