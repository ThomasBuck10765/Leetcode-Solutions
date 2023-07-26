using System.Linq;

namespace Leetcode.Problem1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int max = nums.Max();

            for (int index1 = 0; index1 < (length - 1); index1++)
            {
                int number1 = nums[index1];

                if (number1 + max >= target)
                {
                    for (int index2 = index1 + 1; index2 < length; index2++)
                    {
                        int number2 = nums[index2];

                        if (number1 + number2 == target)
                        {
                            return new int[] { index1, index2 };
                        }
                    }
                }
            }

            return null;
        }
    }
}
