using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SortingOperations;
using NUnit.Framework;

namespace Calculator.Tests.SortingOperations
{
    [TestFixture]
    public class InsertMethodTests
    {
        [Test]
        public void CalculateTest()
        {
            InsertMethod choseMethod = new InsertMethod();
            int[] example = { 1, 2, 3 };
            int[] data = { 2, 1, 3 };
            Assert.AreEqual(example, choseMethod.SortingCalculate(data), "Sorting operation do not working");
        }
    }
}
