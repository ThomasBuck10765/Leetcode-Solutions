using System;

namespace Leetcode.Problem11
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int MaxArea(int[] height)
        {
            int n = height.Length;

            int left = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                if (height[left] > height[i]) continue;

                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Min(height[i], height[j]) * (j - i) > max)
                    {
                        left = i;
                        max = Math.Min(height[i], height[j]) * (j - i);
                    }
                }
            }

            return max;
        }
    }
}
