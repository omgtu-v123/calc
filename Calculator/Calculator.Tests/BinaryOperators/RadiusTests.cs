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
    public class RadiusTests
    {
        [Test]
        public void CalculateTest()
        {
            Radius radius = new Radius();
            Assert.AreEqual("5", radius.Calculate(3, 4), "sqrt(16+9) != 5");
        }
    }
}
