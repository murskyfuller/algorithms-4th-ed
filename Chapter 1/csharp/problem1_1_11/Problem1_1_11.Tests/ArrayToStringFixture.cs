using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_1_11.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class ArrayToStringFixture
    {
        private static ArrayToStringConverter _converter;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _converter = new ArrayToStringConverter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArrayToString_Throws_ArgumentNull()
        {
            _converter.ArrayToString(null);
        }

        [TestMethod]
        public void ArrayToString_Returns_Correctly_All_True()
        {
            // Arrange
            var input = new bool[] { true, true, true };

            // Act
            var response = _converter.ArrayToString(input);

            // Assert
            Assert.AreEqual("* * *", response);
        }

        [TestMethod]
        public void ArrayToString_Returns_Correctly_All_False()
        {
            // Arrange
            var input = new bool[] { false, false, false };

            // Act
            var response = _converter.ArrayToString(input);

            // Assert
            Assert.AreEqual("     ", response);
        }

        [TestMethod]
        public void ArrayToString_Returns_Correctly_Mixed_Values()
        {
            // Arrange
            var input = new bool[] { true, false, true };

            // Act
            var response = _converter.ArrayToString(input);

            // Assert
            Assert.AreEqual("*   *", response);
        }
    }
}
