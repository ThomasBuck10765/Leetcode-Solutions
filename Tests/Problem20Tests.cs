using Leetcode.Problem20;
using NUnit.Framework;

namespace Tests
{
    public class Problem20Tests
    {
        [Test]
        public void Test1()
        {
            var expected = true;

            var s = "()";

            var actual = Program.IsValid(s);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = true;

            var s = "()[]{}";

            var actual = Program.IsValid(s);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = false;

            var s = "(]";

            var actual = Program.IsValid(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
