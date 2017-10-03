using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RomanNumbers;
namespace RomanNumbersTest
{
    [TestClass]
    public class RomanConverterTest
    {
        IConverter roman;

        [TestInitialize]
        public void Initialize()
        {
            roman = new Converter();
        }

        [TestMethod]
        public void TestNumberOne()
        {
            var val = roman.Convert("1");
            Assert.AreEqual(val, "I");
        }

        [TestMethod]
        public void TestNumber4()
        {
            var val = roman.Convert("4");
            Assert.AreEqual(val, "IV");
        }


        [TestMethod]
        public void TestNumber5()
        {
            var val = roman.Convert("5");
            Assert.AreEqual(val, "V");
        }

        [TestMethod]
        public void TestNumber2()
        {
            var val = roman.Convert("2");
            Assert.AreEqual(val, "II");
        }

        [TestMethod]
        public void TestNumber12()
        {
            var val = roman.Convert("12");
            Assert.AreEqual(val, "XII");
        }

        [TestMethod]
        public void TestNumber948()
        {
            var val = roman.Convert("948");
            Assert.AreEqual(val, "CMXLVIII");
        }


        [TestMethod]
        public void TestNumber0()
        {
            var val = roman.Convert("0");
            Assert.AreEqual(val, "N");
        }

      
    }
}
