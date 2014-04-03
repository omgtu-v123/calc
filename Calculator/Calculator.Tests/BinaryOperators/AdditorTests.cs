using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.BinaryOperators;
using NUnit.Framework;

namespace Calculator.Tests.BinaryOperators
{
    [TestFixture]
    public class AdditorTests
    {
        [Test]
        public void CalculateTest()
        {
            Additor additor = new Additor();
            Assert.AreEqual("10", additor.Calculate(5,5), "5 + 5 != 10");
        }
    }
}
