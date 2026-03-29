using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace Lab2.Tests
{
    [TestClass]
    public class Task1Tests
    {
        /// <summary>
        /// Tests the odd element counting functionality, including negative numbers.
        /// </summary>
        [TestMethod]
        public void CountOddElements_ReturnsCorrectAmount()
        {
            int[] array = { 1, 2, -3, 4, 5, 6, -7 };
            int expected = 4;

            int result = Task1.CountOddElements(array);

            Assert.AreEqual(expected, result);
        }
    }
}