using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbersTest
{
    [TestClass]
    public class ParserTest
    {

        IParser parser;

        [TestInitialize]
        public void Initialize()
        {
            parser = new Parser();
        }

        [TestMethod]
        public void TestArgumentExceptionForNaN()
        {
            Assert.ThrowsException<ArgumentException>(() => parser.ParseString("s"));
        }

        [TestMethod]
        public void TestArgumentExceptionForNonRangeNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => parser.ParseString("7888"));
        }
    }
}
