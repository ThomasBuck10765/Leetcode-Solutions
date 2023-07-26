using Leetcode.Problem11;
using NUnit.Framework;

namespace Tests
{
    public class Problem11Tests
    {
        [Test]
        public void Test1()
        {
            var expected = 49;

            var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var actual = Program.MaxArea(height);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = 1;

            var height = new int[] { 1, 1 };

            var actual = Program.MaxArea(height);

            Assert.AreEqual(expected, actual);
        }
    }
}
