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
    public class LogarithmTests
    {
        [Test]
        public void CalculateTest()
        {
            Logarithm logarithm = new Logarithm();
            Assert.AreEqual(3, logarithm.Calculate(8, 2), "log(2,8) != 3");
        }
    }
}
