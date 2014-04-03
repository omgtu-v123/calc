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
                Assert.AreEqual("1", acosiner.Calculate(0), "cos 0 != 1");
            }
        }
    }
}
