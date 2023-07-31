using Leetcode.Problem5;
using NUnit.Framework;

namespace Tests
{
    public class Problem5Tests
    {
        [Test]
        public void Test1()
        {
            string expected = "aba";

            string s = "babad";

            var actual = Program.LongestPalindrome(s);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            string expected = "bb";

            string s = "cbbd";

            var actual = Program.LongestPalindrome(s);

            Assert.AreEqual(expected, actual);
        }
    }
}