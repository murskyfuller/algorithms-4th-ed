using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1_1_9.Tests
{
    [TestClass]
    public class IsDivisibleByFixture
    {
        private static Solution _solution;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _solution = new Solution();
        }

        [TestMethod]
        public void Returns_True_For_4_2()
        {
            Assert.IsTrue(_solution.IsDivisibleBy(4, 2));
        }

        [TestMethod]
        public void Returns_True_For_3_2()
        {
            Assert.IsFalse(_solution.IsDivisibleBy(4, 3));
        }

        [TestMethod]
        public void Returns_True_For_9_3()
        {
            Assert.IsTrue(_solution.IsDivisibleBy(9, 3));
        }

        [TestMethod]
        public void Returns_True_For_9_4()
        {
            Assert.IsFalse(_solution.IsDivisibleBy(9, 4));
        }
    }
}
