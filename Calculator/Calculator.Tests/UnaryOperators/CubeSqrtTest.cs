using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.UnaryOperators
{
    public class CubeSqrtTest
    {
        [TestFixture]
        public class CubeSqrtTests
        {
            [Test]
            public void CalculateTest()
            {
                CubeSqrt cubesqrt = new CubeSqrt();
                Assert.AreEqual("3", cubesqrt.Calculate(27), "cube sqrt (27) != 3");
            }
        }
    }
}
