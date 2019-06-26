using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            PointList list = new PointList();
            list.Add(10);
            Assert.AreEqual(10, list.FindByIndex(0).Number);

        }
        [TestMethod]
        public void TestMethod3()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Delete(0);
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestMethod4()
        {
            PointList list = new PointList();
            Point p = new Point(10);
            list.Add(p);
            Assert.AreEqual(true, list.Find(p));
        }
        [TestMethod]
        public void TestMethod5()
        {
            PointList list = new PointList();
            list.Add(1);
            Point p = new Point(10);
            list.Add(p);
            Assert.AreEqual(true, list.Find(p));
        }
        [TestMethod]
        public void TestMethod6()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Delete(3);
            list.Delete(-1);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void TestMethod7()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            
            Assert.AreEqual(3, list.FindByIndex(3).Number);
        }
        [TestMethod]
        public void TestMethod8()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(false, list.Find(new Point(1)));
        }
        [TestMethod]
        public void TestMethod9()
        {
            PointList list = new PointList();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(null, list.FindByIndex(6));
        }
    }
}
