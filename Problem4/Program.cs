using System.Linq;
using System;

namespace Leetcode.Problem4
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int totalLength = length1 + length2;

            if (totalLength == 1)
            {
                return (length1 == 0) ? nums2[0] : nums1[0];
            }

            int index1 = 0;
            int index2 = 0;

            int number1 = 0;
            int number2 = 0;

            while (index1 + index2 < (totalLength / 2) + 1)
            {
                number2 = number1;
                if (index1 < length1 && index2 == length2 || index1 < length1 && nums1[index1] < nums2[index2])
                {
                    number1 = nums1[index1];
                    index1++;
                }
                else if (index2 < length2 && index1 == length1 || index2 < length2 && nums2[index2] < nums1[index1])
                {
                    number1 = nums2[index2];
                    index2++;
                }
                else
                {
                    number1 = nums1[index1];
                    index1++;
                }
            }

            return (totalLength % 2 == 0 ? (number1 + number2) / 2f : number1);        
        }
    }
}
