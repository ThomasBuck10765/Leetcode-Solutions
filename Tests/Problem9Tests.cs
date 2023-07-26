using Leetcode.Problem9;
using NUnit.Framework;

namespace Tests
{
    class Problem9Tests
    {
        [Test]
        public void Test1()
        {
            var expected = true;

            var x = 121;

            var actual = Program.IsPalindrome(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = false;

            var x = -121;

            var actual = Program.IsPalindrome(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = false;

            var x = 10;

            var actual = Program.IsPalindrome(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
