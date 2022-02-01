using Calculator.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Calculator
{
    [TestClass]
    public class TestDiv
    {
       [TestMethod]
        public void Div_10_2_5()
        {
            var x = 10;
            var y = 2;


            var actual = Calc.Div(x, y);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Div_5_2_25()
        {
            var x = 5;
            var y = 2;


            var actual = Calc.Div(x, y);
            var expected = 2.5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_Exception()
        {
            var x = 10;
            var y = 0;


            Calc.Div(x, y);
        }
    }
}
