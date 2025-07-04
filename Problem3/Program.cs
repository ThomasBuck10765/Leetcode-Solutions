using System;
using System.Collections.Generic;

namespace Leetcode.Problem3
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var maxLength = 0;
            var left = 0;
            // Dictionary to reflect the index of a previous character
            var charDict = new Dictionary<char, int>();

            for (var right = 0; right < s.Length; right++)
            {
                var c = s[right];
                if (charDict.ContainsKey(c))
                {
                    // Start a new substring we have a repeating character
                    left = Math.Max(charDict[c] + 1, left);
                }
                charDict[c] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
