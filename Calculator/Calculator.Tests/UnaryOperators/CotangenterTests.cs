using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class CotangenterTest
    {
        [TestFixture]
        public class CotangenterTests
        {
            [Test]
            public void CalculateTest()
            {
                Cotangenter cotangenter = new Cotangenter();
                Assert.AreEqual(-0.2958, cotangenter.Calculate(5), 0.0001, "cotangenter != 0");
            }
            [Test]
            [ExpectedException(typeof(Exception))]
            public void CalculateFailTest()
            {
                Cotangenter cotangenter = new Cotangenter();
                double result = cotangenter.Calculate(Math.PI + 1);
            }
        }
    }
}
