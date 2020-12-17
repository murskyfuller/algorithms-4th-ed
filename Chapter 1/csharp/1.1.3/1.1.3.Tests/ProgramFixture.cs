using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._1._3.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProgramFixture
    {
        // ******
        // AreEqual
        // ******

        [TestMethod]
        public void AreEqual_ReturnsTrue_Number()
        {
            // Act
            var result = Solution.AreEqual(1, 1, 1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreEqual_ReturnsFalse_Number()
        {
            // Act
            var result = Solution.AreEqual(1, 2, 2);

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
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("1 2 2");
            Console.SetIn(input);

            // Act
            Solution.Run();
            
            // Assert
            Assert.AreEqual("not equal", output.ToString());
        }

        [TestMethod]
        public void Program_Success_PrintsEqual()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("2 2 2");
            Console.SetIn(input);

            // Act
            Solution.Run();

            // Assert
            Assert.AreEqual("equal", output.ToString());
        }
    }
}
