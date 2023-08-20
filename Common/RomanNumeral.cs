using System.Collections.Generic;

namespace Common
{
    public static class RomanNumeral
    {
        public static Dictionary<char, int> RomanNumeralDict = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public static Dictionary<int, char> RomanNumeralIntDict = new Dictionary<int, char>()
        {
            {1000, 'M'},
            {500, 'D'},
            {100, 'C' },
            {50, 'L' },
            {10, 'X' },
            {5, 'V' },
            {1, 'I' },
        };
    }
}
