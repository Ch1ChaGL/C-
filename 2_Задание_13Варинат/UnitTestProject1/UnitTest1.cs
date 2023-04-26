using _2_Задание_13Варинат;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = digitalRadical.CalculateDigitalRadical(326);
            var expected = 2;

            Assert.AreEqual(expected, actual, "Тест не пройден");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var actual = digitalRadical.CalculateDigitalRadical(1);
            var expected = 1;

            Assert.AreEqual(expected, actual, "Тест не пройден");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var actual = digitalRadical.CalculateDigitalRadical(432);
            var expected = 9;

            Assert.AreEqual(expected, actual, "Тест не пройден");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Значение не входит в множество")]
        public void TestMethod4()
        {
           digitalRadical.CalculateDigitalRadical(0); 
        }
    }
}
