using System;
using System.Linq;

namespace Leetcode.Problem7
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int Reverse(int x)
        {
            int result = 0;
            int remainder;
            int temp;

            while (x != 0)
            {
                remainder = x % 10;
                temp = (result * 10) + remainder;

                // Has Overflowed
                if ((temp - remainder) / 10 != result)
                {
                    return 0;
                }

                result = temp;
                x /= 10;
            }

            return result;
        }
    }
}
