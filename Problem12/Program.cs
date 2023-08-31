using Leetcode.Common;

namespace Leetcode.Problem12
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string IntToRoman(int num)
        {
            string roman = "";

            if (num <= 0) return roman;

            foreach(var val in RomanNumeral.RomanNumeralIntDict)
            {
                while (num >= val.Key)
                {
                    roman += val.Value;
                    num -= val.Key;
                }
            }

            return roman;
        }
    }
}
