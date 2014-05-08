using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class TangenterTest
    {
        [TestFixture]
        public class TangenterTests
        {
            [Test]
            public void CalculateTest()
            {
                Tangenter tangenter = new Tangenter();
                Assert.AreEqual(-3.3805, tangenter.Calculate(5), 0.0001, "tangenter != 0");
            }
            [Test]
            [ExpectedException(typeof(Exception))]
            public void CalculateFailTest()
            {
                Tangenter tangenter = new Tangenter();
                double result = tangenter.Calculate(Math.PI / 2);
            }
        }
    }
}
