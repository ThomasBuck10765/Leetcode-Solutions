using Leetcode.Common;
using Leetcode.Problem24;
using NUnit.Framework;

namespace Tests
{
    public class Problem24Tests
    {
        [Test]
        public void Test1()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 2, 1, 4, 3 });

            var head = ListNodeHelper.GenerateListNode(new int[] { 1, 2, 3, 4 });

            var actual = Program.SwapPairs(head);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { });

            var head = ListNodeHelper.GenerateListNode(new int[] { });

            var actual = Program.SwapPairs(head);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 1 });

            var head = ListNodeHelper.GenerateListNode(new int[] { 1 });

            var actual = Program.SwapPairs(head);

            ListNodeHelper.CompareListNodes(expected, actual);
        }
    }
}
