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
    public class BubbleMethodTests
    {
        [Test]
        public void CalculateTest()
        {
            BubbleMethod bubbleMethod = new BubbleMethod();
            int[] example = {1, 2, 3};
            int[] data = {2, 1, 3};
            Assert.AreEqual(example, bubbleMethod.SortingCalculate(data), "Sorting operation do not working");
        }
    }
}
