using Leetcode.Problem4;
using NUnit.Framework;

namespace Tests
{
    public class Problem4Tests
    {
        [Test]
        public void Test1()
        {
            double expected = 2.0;

            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            double expected = 2.5;

            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3, 4 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            double expected = 1;
            var nums1 = new int[] { };
            var nums2 = new int[] { 1 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            double expected = 0.0;
            var nums1 = new int[] { 0, 0, 0, 0, 0 };
            var nums2 = new int[] { -1, 0, 0, 0, 0, 0, 1 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            double expected = 3.5;
            var nums1 = new int[] { 3, 4 };
            var nums2 = new int[] { };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6()
        {
            double expected = 2.5;
            var nums1 = new int[] { };
            var nums2 = new int[] { 1, 2, 3, 4 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test7()
        {
            double expected = 3.0;
            var nums1 = new int[] { };
            var nums2 = new int[] { 1, 2, 3, 4, 5 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test8()
        {
            double expected = 100000.5;
            var nums1 = new int[] { 100001 };
            var nums2 = new int[] { 100000 };

            var actual = Program.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expected, actual);
        }
    }
}