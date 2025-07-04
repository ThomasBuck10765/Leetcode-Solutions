using Leetcode.Problem3;
using NUnit.Framework;

namespace Tests
{
    public class Problem3Tests
    {
        [Test]
        public void Test1()
        {
            var expected = 3;

            var actual = Program.LengthOfLongestSubstring("abcabcbb");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = 1;

            var actual = Program.LengthOfLongestSubstring("bbbbb");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = 3;

            var actual = Program.LengthOfLongestSubstring("pwwkew");

            Assert.AreEqual(expected, actual);
        }
    }
}
