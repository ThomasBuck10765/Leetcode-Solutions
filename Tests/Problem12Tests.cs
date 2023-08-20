using Leetcode.Problem12;
using NUnit.Framework;

namespace Tests
{
    public class Problem12Tests
    {
        [Test]
        public void Test1()
        {
            var expected = "III";

            var num = 3;

            var actual = Program.IntToRoman(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = "LVIII";

            var num = 58;

            var actual = Program.IntToRoman(num);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test3()
        {
            var expected = "MCMXCIV";

            var num = 1994;

            var actual = Program.IntToRoman(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
