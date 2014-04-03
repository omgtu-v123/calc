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
    public class PowTests
    {
        [Test]
        public void CalculateTest()
        {
            Pow pow = new Pow();
            Assert.AreEqual("25", pow.Calculate(5, 2), "5^2 != 25");
        }
    }
}
