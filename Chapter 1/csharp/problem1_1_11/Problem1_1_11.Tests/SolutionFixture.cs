using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Problem1_1_11.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class SolutionFixture
    {
        public static Mock<IArrayToStringConverter> _converter = new Mock<IArrayToStringConverter>();
        public static Solution _solution;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _solution = new Solution(_converter.Object);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _converter.Reset();
        }

        [TestMethod]
        public void Execute_Outputs_To_Console_With_Converter_Result()
        {
            // Arrange
            var toConvert = new bool[][] { new bool[] { true }, new bool[] { true }, new bool[] { true } };

            var expectedOutput = "test-return-value";
            _converter.Setup(m => m.TwoDimenionsalArrayToString(It.Is<bool[][]>(v => v.Equals(toConvert))))
                .Returns(expectedOutput);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _solution.Execute(toConvert);

            // Assert
            Assert.AreEqual(expectedOutput, output.ToString());
        }
    }
}
