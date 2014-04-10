using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.BinaryOperators;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class AcosinerTest
    {
        [TestFixture]
        public class AcosinerTests
        {
            [Test]
            public void CalculateTest()
            {
                Acosiner acosiner = new Acosiner();
                Assert.AreEqual(1.5708, acosiner.Calculate(0), 0.0001, "acos 0 != 1,5707963267949");
            }
        }
    }
}
