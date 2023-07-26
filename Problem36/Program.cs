using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problem36
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!IsRowValid(board[i])) return false;
                if (!IsColumnValid(board, i)) return false;

                if (i % 3 == 0)
                {
                    for (int j = 0; j < 9; j += 3)
                    {
                        if (!IsBoxValid(board, i, j)) return false;
                    }
                }
            }

            return true;
        }

        private static bool IsBoxValid(char[][] board, int row, int column)
        {
            List<char> seen = new List<char> { };

            for (int i = row; i < row + 3; i++)
            {
                for (int j = column; j < column + 3; j++)
                {
                    char value = board[i][j];
                    if (value == '.') continue;

                    if (seen.Contains(value))
                    {
                        return false;
                    }
                    else
                    {
                        seen.Add(value);
                    }
                }
            }

            return true;
        }

        private static bool IsColumnValid(char[][] board, int column)
        {
            List<char> seen = new List<char> { };

            for (int i = 0; i < 9; i++)
            {
                char value = board[i][column];
                if (value == '.') continue;

                if (seen.Contains(value))
                {
                    return false;
                }
                else
                {
                    seen.Add(value);
                }
            }

            return true;
        }

        private static bool IsRowValid(char[] row)
        {
            for (int i = 0; i < 9; i++)
            {
                if (row[i] == '.') continue;

                if (row.Count(x => x == row[i]) != 1) return false;
            }

            return true;
        }
    }
}
