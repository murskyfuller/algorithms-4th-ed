using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1._1._3.Tests
{
    [TestClass]
    [TestCategory("Unit")]
    public class StdInFixture
    {
        private StdIn _stdIn;

        [TestInitialize]
        public void TestInt()
        {
            _stdIn = new StdIn();
        }

        [TestMethod]
        public void Prompt_Success_ReadsResponseFromConsole()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            var expectedMessage = "Some input";
            var input = new StringReader(expectedMessage);
            Console.SetIn(input);

            // Act
            var result = _stdIn.Prompt("Some deep and philosphical question");

            // Assert
            Assert.AreEqual(expectedMessage, result);
        }
    }
}
