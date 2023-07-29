using Leetcode.Common;
using Leetcode.Problem21;
using NUnit.Framework;

namespace Tests
{
    public class Problem21Tests
    {
        [Test]
        public void Test1()
        {
            ListNode expected = ListNodeHelper.GenerateListNode(new int[] { 1, 1, 2, 3, 4, 4 });

            ListNode list1 = ListNodeHelper.GenerateListNode(new int[] { 1, 2, 4 });
            ListNode list2 = ListNodeHelper.GenerateListNode(new int[] { 1, 3, 4 });

            var actual = Program.MergeTwoLists(list1, list2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test2()
        {
            ListNode expected = ListNodeHelper.GenerateListNode(new int[] { });

            ListNode list1 = ListNodeHelper.GenerateListNode(new int[] { });
            ListNode list2 = ListNodeHelper.GenerateListNode(new int[] { });

            var actual = Program.MergeTwoLists(list1, list2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test3()
        {
            ListNode expected = ListNodeHelper.GenerateListNode(new int[] { 0 });

            ListNode list1 = ListNodeHelper.GenerateListNode(new int[] { });
            ListNode list2 = ListNodeHelper.GenerateListNode(new int[] { 0 });

            var actual = Program.MergeTwoLists(list1, list2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test4()
        {
            ListNode expected = ListNodeHelper.GenerateListNode(new int[] { -10, -10, -9, -7, -4, 1, 6, 6 });

            ListNode list1 = ListNodeHelper.GenerateListNode(new int[] { -10, -10, -9, -4, 1, 6, 6 });
            ListNode list2 = ListNodeHelper.GenerateListNode(new int[] { -7 });

            var actual = Program.MergeTwoLists(list1, list2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }
    }
}