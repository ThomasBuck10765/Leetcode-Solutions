using Leetcode.Problem2;
using System.Linq;
using System;
using NUnit.Framework;
using Newtonsoft.Json;
using Leetcode.Common;

namespace Tests
{
    public class Problem2Tests
    {
        [Test]
        public void Test1()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 7, 0, 8 });

            var l1 = ListNodeHelper.GenerateListNode(new int[] { 2, 4, 3 });
            var l2 = ListNodeHelper.GenerateListNode(new int[] { 5, 6, 4 });

            var actual = Program.AddTwoNumbers(l1, l2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 0 });

            var l1 = ListNodeHelper.GenerateListNode(new int[] { 0 });
            var l2 = ListNodeHelper.GenerateListNode(new int[] { 0 });

            var actual = Program.AddTwoNumbers(l1, l2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });

            var l1 = ListNodeHelper.GenerateListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var l2 = ListNodeHelper.GenerateListNode(new int[] { 9, 9, 9, 9 });

            var actual = Program.AddTwoNumbers(l1, l2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }

        [Test]
        public void Test4()
        {
            var expected = ListNodeHelper.GenerateListNode(new int[] { 0, 1 });

            var l1 = ListNodeHelper.GenerateListNode(new int[] { 5 });
            var l2 = ListNodeHelper.GenerateListNode(new int[] { 5 });

            var actual = Program.AddTwoNumbers(l1, l2);

            ListNodeHelper.CompareListNodes(expected, actual);
        }
    }
}