using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class AcotangenterTest
    {
        [TestFixture]
        public class AcotangenterTests
        {
            [Test]
            public void CalculateTest()
            {
                Acotangenter acotangenter = new Acotangenter();
                Assert.AreEqual("1,5707963267949", acotangenter.Calculate(0), "arcctg 0 != 1,5707963267949");
            }
        }
    }
}