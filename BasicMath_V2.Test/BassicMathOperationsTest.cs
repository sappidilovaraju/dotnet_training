using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath_V2;

namespace BasicMath_V2.Test
{
    [TestClass]
    public class BassicMathOperationsTest
    {
        private BasicMathOperations _basicMathOperations;

        [TestInitialize]
        public void TestIntialize()
        {
            _basicMathOperations = new BasicMathOperations();
        }

        [TestMethod]
        public void Test_Add_Positive_1()
        {
            // Arrange
            int a = 2, b = 3;
            int expected = 5;

            // Act
            int atual = _basicMathOperations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, atual);
        }

        [TestMethod]
        public void Test_Add_Negative_1()
        {
            // Arrange
            int a = 2, b = 3;
            int expected = 4;

            // Act
            int atual = _basicMathOperations.Add(a, b);

            // Assert
            Assert.AreNotEqual(expected, atual);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (_basicMathOperations != null)
            {
                _basicMathOperations = null;
            }
        }
    }
}
