using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_1_5.Tests
{
    [TestClass]
    public class SolutionFixture
    {
        private Solution _solution;

        [TestInitialize]
        public void TestInit()
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void Returns_True_When_Both_In_Range()
        {
            Assert.IsTrue(_solution.Execute(0.1, 0.9));
        }

        [TestMethod]
        public void Returns_False_For_0()
        {
            Assert.IsFalse(_solution.Execute(0, 0.9));
        }

        [TestMethod]
        public void Returns_False_For_1()
        {
            Assert.IsFalse(_solution.Execute(0.1, 1));
        }

        [TestMethod]
        public void Returns_False_For_Negative_Value()
        {
            Assert.IsFalse(_solution.Execute(-0.1, 0.9));
        }

        [TestMethod]
        public void Returns_False_For_Value_Greater_Than_1()
        {
            Assert.IsFalse(_solution.Execute(0.1, 1.1));
        }

        [TestMethod]
        public void Returns_False_For_Both_Out_Of_Range()
        {
            Assert.IsFalse(_solution.Execute(-0.1, 1.1));
        }
    }
}
