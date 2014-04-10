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
    public class MultiplicatorTests
    {
        [Test]
        public void CalculateTest()
        {
            Multiplicator multiplicator = new Multiplicator();
            Assert.AreEqual(25, multiplicator.Calculate(5, 5), "5*5 != 25");
        }
    }
}
