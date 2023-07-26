
namespace Leetcode.Problem9
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            char[] xChars = x.ToString().ToCharArray();

            int xCharsLength = xChars.Length;
            int iteratorLimit = xCharsLength / 2;

            if (xCharsLength % 2 != 0)
            {
                iteratorLimit++;
            }

            for (int i = 0; i < iteratorLimit; i++)
            {
                if (xChars[i] != xChars[xCharsLength - (i+1)])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
