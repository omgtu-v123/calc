using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class AsinerTest
    {
        [TestFixture]
        public class AsinerTests
        {
            [Test]
            public void CalculateTest()
            {
                Asiner asiner = new Asiner();
                Assert.AreEqual(0, asiner.Calculate(0), "asiner 0 != 0");
            }
        }
    }
}
