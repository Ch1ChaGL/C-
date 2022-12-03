using _11;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OddArray()
        {
            var arr = new double[] { 1, 2, 3, 4, 5 };
            var expected = 3;
            Form1 form1 = new Form1();
            var actual = form1.GetY(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvenArray()
        {
            var arr = new double[] { 1, 2, 3, 4 };
            var expected = -2;
            Form1 form1 = new Form1();
            var actual = form1.GetY(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
