using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class SinerTest
    {
        [TestFixture]
        public class SinerTests
        {
            [Test]
            public void CalculateTest()
            {
                Siner siner = new Siner();
                Assert.AreEqual(0, siner.Calculate(0), "siner != 0");
            }
        }
    }
}
