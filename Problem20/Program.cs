using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problem20
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();

            bool isValid = chars.Count(s => s == '(') == chars.Count(s => s == ')')
                && chars.Count(s => s == '{') == chars.Count(s => s == '}')
                && chars.Count(s => s == '[') == chars.Count(s => s == ']');

            if (!isValid) return isValid;

            List<char> neededChars = new List<char> { };

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == neededChars.LastOrDefault())
                {
                    neededChars.RemoveAt(neededChars.Count - 1);
                }
                else
                {
                    neededChars.Add(ClosingChar(chars[i]));
                }
            }

            return (neededChars.Count == 0);
        }

        private static char ClosingChar(char c)
        {
            switch (c)
            {
                case '(':
                    return ')';
                    break;
                case '[':
                    return ']';
                    break;
                case '{':
                    return '}';
                    break;
                default:
                    return ' ';
                    break;
            };
        }
    }
}
