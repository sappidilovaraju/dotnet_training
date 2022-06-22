using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMath.Test
{
    [TestClass]
    public class BasicMathTest
    {
        private BasicMath _basicMath;
        
        [TestInitialize]
        public void Initialize()
        {
            _basicMath = new BasicMath();
        }

        [TestMethod]
        public void Test_Add_Positive_1()
        {
            // Arrange
            double num1 = 1;
            double num2 = 2;
            double expected = 3;

            // Act
            double actual = _basicMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Add_Negative_1()
        {
            // Arrange
            double num1 = 1;
            double num2 = 2;
            double expected = 1;

            // Act
            double actual = _basicMath.Add(num1, num2);

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (_basicMath != null)
            {
                _basicMath = null;
            }
        }
    }
}
