using Leetcode.Problem7;
using NUnit.Framework;

namespace Tests
{
    public class Problem7Tests
    {
        [Test]
        public void Test1()
        {
            int expected = 321;

            var x = 123;

            var actual = Program.Reverse(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            int expected = -321;

            var x = -123;

            var actual = Program.Reverse(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int expected = 21;

            var x = 120;

            var actual = Program.Reverse(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            int expected = 0;

            var x = 1534236469;

            var actual = Program.Reverse(x);

            Assert.AreEqual(expected, actual);
        }
    }
}