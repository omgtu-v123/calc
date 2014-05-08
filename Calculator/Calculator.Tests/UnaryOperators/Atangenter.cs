using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class AtangenterTest
    {
        [TestFixture]
        public class AtangenterTests
        {
            [Test]
            public void CalculateTest()
            {
                Atangenter atangenter = new Atangenter();
                Assert.AreEqual(0, atangenter.Calculate(0), "arctg 0 != 0");
            }
            [Test]
            [ExpectedException(typeof(Exception))]
            public void CalculateFailTest()
            {
                Atangenter atangenter = new Atangenter();
                double result = atangenter.Calculate(Math.PI + 1);
            }
        }
    }
}