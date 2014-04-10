using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class SqrtTest
    {
        [TestFixture]
        public class SqrtTests
        {
            [Test]
            public void CalculateTest()
            {
                Sqrt sqrt = new Sqrt();
                Assert.AreEqual(3, sqrt.Calculate(9), "sqrt (9) != 3");
            }
        }
    }
}
