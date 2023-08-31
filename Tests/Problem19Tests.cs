using Leetcode.Common;
using Leetcode.Problem19;
using NUnit.Framework;

namespace Tests
{
    public class Problem19Tests
    {
        [Test]
        public void Test1()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 1, 2, 3, 5 });

            var head = ListNodeHelper.GenerateListNode(new int[] { 1, 2, 3, 4, 5 });
            var n = 2;

            var actual = Program.RemoveNthFromEnd(head, n);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { });

            var head = ListNodeHelper.GenerateListNode(new int[] { 1 });
            var n = 1;

            var actual = Program.RemoveNthFromEnd(head, n);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 1 });

            var head = ListNodeHelper.GenerateListNode(new int[] { 1, 2 });
            var n = 1;

            var actual = Program.RemoveNthFromEnd(head, n);

            ListNodeHelper.CompareListNodes(expected, actual);
        }
    }
}
