using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_1_9.Tests
{
    [TestClass]
    public class SolutionFixture
    {
        private static Solution _solution;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void Returns_Correct_Value_For_1()
        {
            Assert.AreEqual("1", _solution.Execute(1));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_2()
        {
            Assert.AreEqual("10", _solution.Execute(2));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_3()
        {
            Assert.AreEqual("11", _solution.Execute(3));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_7()
        {
            Assert.AreEqual("111", _solution.Execute(7));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_8()
        {
            Assert.AreEqual("1000", _solution.Execute(8));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_13()
        {
            Assert.AreEqual("1101", _solution.Execute(13));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_15()
        {
            Assert.AreEqual("1111", _solution.Execute(15));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_16()
        {
            Assert.AreEqual("10000", _solution.Execute(16));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_17()
        {
            Assert.AreEqual("10001", _solution.Execute(17));
        }

        [TestMethod]
        public void Returns_Correct_Value_For_54673890()
        {
            Assert.AreEqual("11010000100100000111100010", _solution.Execute(54673890));
        }
    }
}
