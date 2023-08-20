using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problem13
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int RomanToInt(string s)
        {
            int num = 0;

            char[] charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char current = charArray[i];

                // Considerations for CM (900), CD (500), XC (90), XL (40), IX (9), IV (4)
                if (i <= charArray.Length - 2)
                {
                    char next = charArray[i + 1];

                    for (int j = 0; j < RomanNumeral.RomanNumeralDict.Keys.Count - 2; j += 2)
                    {
                        int addition = 0;
                        if (current == RomanNumeral.RomanNumeralDict.ElementAt(j).Key)
                        {
                            if (next == RomanNumeral.RomanNumeralDict.ElementAt(j + 1).Key)
                            {
                                addition += 4;
                            }
                            else if (next == RomanNumeral.RomanNumeralDict.ElementAt(j + 2).Key)
                            {
                                addition += 9;
                            }
                        }

                        if (addition != 0)
                        {
                            num += addition * (int)Math.Pow(10, j / 2);
                            i++;
                            goto Considered;
                        }
                    }
                }

                num += RomanNumeral.RomanNumeralDict[current];

            Considered:
                continue;
            }
            
            return num;
        }
    }
}
