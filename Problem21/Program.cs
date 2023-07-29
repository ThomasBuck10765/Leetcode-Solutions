using Leetcode.Common;

namespace Leetcode.Problem21
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var MergedList = new ListNode();

            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            if (list1.val > list2.val)
            {
                MergedList.val = list2.val;
                MergedList.next = (list2.next == null) ? list1 : MergeTwoLists(list1, list2.next);
            }
            else
            {
                MergedList.val = list1.val;
                MergedList.next = (list1.next == null) ? list2 : MergeTwoLists(list1.next, list2);

            }

            return MergedList;
        }
    }
}
