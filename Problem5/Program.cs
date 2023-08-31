
namespace Leetcode.Problem5
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string LongestPalindrome(string s)
        {
            int length = s.Length;
            string answer = s[0] + "";
            // 1-D array to check whether substrings are palindromes or not using dynamic programming
            bool[] paths = new bool[length];

            for (int i = length - 1; i >= 0; i--)
            {
                string substring = s[i].ToString();
                for (int j = length - 1; j >= i; j--)
                {
                    if (i == j)
                    {
                        paths[i] = true;
                    }
                    else if (j == i + 1)
                    {
                        paths[j] = s[i] == s[j];
                    }
                    else
                    {
                        paths[j] = paths[j - 1] && s[i] == s[j];
                    }

                    if (paths[j] && j - i + 1 > answer.Length)
                    {
                        answer = s.Substring(i, j - i + 1);
                    }
                }
            }

            return answer;
        }
    }
}
