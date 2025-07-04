using NUnit.Framework;

namespace Tests
{
    public class Problem14Tests
    {
        [Test]
        public void Test1()
        {
            var expected = "fl";

            var strs = new string[] { "flower", "flow", "flight" };

            var actual = Leetcode.Problem14.Program.LongestCommonPrefix(strs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = "";

            var strs = new string[] { "dog", "racecar", "car" };

            var actual = Leetcode.Problem14.Program.LongestCommonPrefix(strs);

            Assert.AreEqual(expected, actual);
        }
    }
}
