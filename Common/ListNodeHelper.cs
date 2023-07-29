using NUnit.Framework;
using System.Linq;
using Newtonsoft.Json;

namespace Leetcode.Common
{
    public static class ListNodeHelper
    {
        public static void Main()
        {

        }

        public static ListNode GenerateListNode(int[] values)
        {
            if (values.Length > 1)
            {
                return new ListNode(values[0], GenerateListNode(values.Skip(1).ToArray()));
            }
            else if (values.Length == 1)
            {
                return new ListNode(values[0]);
            }
            else
            {
                return null;
            }
        }

        public static void CompareListNodes(ListNode expected, ListNode actual)
        {
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }
    }
}
