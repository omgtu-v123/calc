using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class CosinerTest
    {
        [TestFixture]
        public class CosinerTests
        {
            [Test]
            public void CalculateTest()
            {
                Cosiner cosiner = new Cosiner();
                Assert.AreEqual(1, cosiner.Calculate(0), "cosiner != 1");
            }
        }
    }
}
