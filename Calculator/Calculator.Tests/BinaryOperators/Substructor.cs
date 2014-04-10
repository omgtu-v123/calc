using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator.BinaryOperators;

namespace Calculator.Tests.BinaryOperators
{
    [TestFixture]
    public class SubstructorTests
    {
        [Test]
        public void CalculateTest()
        {
            Substructor substructor = new Substructor();
            Assert.AreEqual(0, substructor.Calculate(5, 5), "5-5 != 0");
        }
    }
}
