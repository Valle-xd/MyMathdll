using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathdll;

namespace MyMathTest
{
    [TestClass]
    public class MathTest
    {
        MyMathdll.SimpleMath m = new SimpleMath();

        [TestMethod]
        public void addTest()
        {

            Assert.IsTrue(m.Add(2, 3) == 5);
        }

        [TestMethod]
        public void SubtractionTestInt1()
        {
            int number1 = 0;
            int number2 = 10;
            int result = SimpleMath.Subtraction(number1, number2);
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void SubtractionTestDouble1()
        {
            double number1 = 0;
            double number2 = 10;
            double result = SimpleMath.Subtraction(number1, number2);
            Assert.AreEqual(-10, result);
        }

        [TestMethod()]
        public void MultiplicationTestInt1()
        {
            int number1 = 10;
            int number2 = 0;
            int result = SimpleMath.Multiplication(number1, number2);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void MultiplicationTestDouble1()
        {
            double number1 = 0;
            double number2 = 10;
            double result = SimpleMath.Multiplication(number1, number2);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void DivisionTestDouble1()
        {
            double number1 = 0;
            double number2 = 10;
            double result = SimpleMath.Division(number1, number2);
            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void DivisionTestInt1()
        {
            int number1 = 0;
            int number2 = 10;
            int result = SimpleMath.Division(number1, number2);
            Assert.AreEqual(0, result);
        }
    }
}
