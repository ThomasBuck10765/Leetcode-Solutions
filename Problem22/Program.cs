using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problem22
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();

            GenerateSingle(result, "", n, 0, 0);

            return result;
        }

        public static void GenerateSingle(List<string> result, string str, int n, int opened, int closed)
        {
            if(opened == closed && opened == n)
            {
                result.Add(str);
                return;
            }

            if (opened < n)
            {
                GenerateSingle(result, str + "(", n, opened + 1, closed);
            }
            if (closed < opened)
            {
                GenerateSingle(result, str + ")", n, opened, closed + 1);
            }
        }
    }
}
