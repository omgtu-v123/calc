using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.BinaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.BinaryOperators
{
    [TestFixture]
    public class RootTests
    {
        [Test]
        public void CalculateTest()
        {
            Root root = new Root();
            Assert.AreEqual(5, root.Calculate(25, 2), "25^0.5 != 5");
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculateFailTest()
        {
            Root root = new Root();
            double result = root.Calculate(-4, 2);
        }
    }
}
