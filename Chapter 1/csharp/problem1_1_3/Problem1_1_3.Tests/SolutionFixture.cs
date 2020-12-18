using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Problem1_1_3.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class SolutionFixture
    {
        private static Mock<IStdIn> _mockStdIn;

        private Solution _solution;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _mockStdIn = new Mock<IStdIn>();
        }

        [TestInitialize]
        public void TestInit()
        {
            _solution = new Solution(_mockStdIn.Object);
        }

        // ******
        // AreEqual
        // ******

        [TestMethod]
        public void AreEqual_ReturnsTrue_Number()
        {
            // Act
            var result = _solution.AreEqual(1, 1, 1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreEqual_ReturnsFalse_Number()
        {
            // Act
            var result = _solution.AreEqual(1, 2, 2);

            // Assert
            Assert.IsFalse(result);
        }

        // ******
        // Run
        // ******
        [TestMethod]
        public void Program_Success_PrintsNotEqual()
        {
            // Arrange
            _mockStdIn.Setup(m => m.Prompt(It.IsAny<string>()))
                .Returns("1,2,2");

            // Act
            var result = _solution.Execute();
            
            // Assert
            Assert.AreEqual("not equal", result);
        }

        [TestMethod]
        public void Program_Success_PrintsEqual()
        {
            // Arrange
            _mockStdIn.Setup(m => m.Prompt(It.IsAny<string>()))
                .Returns("2,2,2");

            // Act
            var result = _solution.Execute();

            // Assert
            Assert.AreEqual("equal", result);
        }
    }
}
