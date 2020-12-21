using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_1_11.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class TwoDimensionalArrayToConsoleGridFixture
    {
        private static ArrayToStringConverter _converter;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _converter = new ArrayToStringConverter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TwoDimArrayToConsoleGrid_Throws_ArgumentNull()
        {
            _converter.TwoDimenionsalArrayToString(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoDimArrayToConsoleGrid_Throws_ArgumentException_With_Null_Item()
        {
            _converter.TwoDimenionsalArrayToString(new bool[][]
            {
                new bool[] { },
                null,
                new bool[] { false }
            });
        }

        [TestMethod]
        public void TwoDimArrayToConsoleGrid_Returns_Correct_Grid()
        {
            // Arrange
            var input = new bool[][]
            {
                new bool[] { true, true, true },
                new bool[] { false, false, false },
                new bool[] { true, false, true }
            };

            // Act
            var response = _converter.TwoDimenionsalArrayToString(input);

            // Assert
            Assert.AreEqual("  1 2 3\n1 * * *\n2      \n3 *   *", response);
        }

        [TestMethod]
        [Ignore]
        public void TwoDimArrayToConsoleGrid_Correct_Spacing_With_More_Than_Ten_Columns()
        {
            // TODO Current implementation does not account for different column width based on digit length.
        }

        [TestMethod]
        [Ignore]
        public void TwoDimArrayToConsoleGrid_Correct_Spacing_With_More_Than_Ten_Rows()
        {
            // TODO Current implementation does not account for different row width based on digit length.
        }
    }
}
