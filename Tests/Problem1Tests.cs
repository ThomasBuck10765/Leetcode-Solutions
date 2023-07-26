using Leetcode.Problem1;
using NUnit.Framework;

namespace Tests
{
    public class Problem1Tests
    {
        [Test]
        public void Test1()
        {
            var expected = new int[] { 0, 1 };

            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var actual = Program.TwoSum(nums, target);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = new int[] { 1, 2 };

            var nums = new int[] { 3, 2, 4 };
            var target = 6;

            var actual = Program.TwoSum(nums, target);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = new int[] { 0, 1 };

            var nums = new int[] { 3, 3 };
            var target = 6;

            var actual = Program.TwoSum(nums, target);

            Assert.AreEqual(expected, actual);
        }
    }
}