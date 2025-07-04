using System.Linq;

namespace Leetcode.Problem14
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var prefix = "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (var word in strs.Skip(1))
                {
                    if (i >= word.Length || word[i] != strs[0][i])
                    {
                        return prefix;
                    }
                }

                prefix += strs[0][i];
            }

            return prefix;
        }
    }
}
