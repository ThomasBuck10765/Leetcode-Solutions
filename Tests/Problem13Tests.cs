using NUnit.Framework;

namespace Tests
{
    public class Problem13Tests
    {
        [Test]
        public void Test1()
        {
            var expected = 3;

            var s = "III";

            var actual = Leetcode.Problem13.Program.RomanToInt(s);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = 58;

            var s = "LVIII";

            var actual = Leetcode.Problem13.Program.RomanToInt(s);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test3()
        {
            var expected = 1994;

            var s = "MCMXCIV";

            var actual = Leetcode.Problem13.Program.RomanToInt(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
