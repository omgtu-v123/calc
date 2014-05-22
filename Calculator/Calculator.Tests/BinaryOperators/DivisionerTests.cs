using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator.BinaryOperators;

namespace Calculator.Tests.BinaryOperators
{
    [TestFixture]
    public class DivisionerTests
    {
        [Test]
        public void CalculateTest()
        {
            Divisioner divisioner = new Divisioner();
            Assert.AreEqual(1, divisioner.Calculate(5,5), "5/5 != 1");
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculateFailTest()
        {
            Divisioner divisioner = new Divisioner();
            double result = divisioner.Calculate(1, 0);
        }
    }
}
