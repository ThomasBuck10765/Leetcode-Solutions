using Leetcode.Problem36;
using NUnit.Framework;

namespace Tests
{
    class Problem36Tests
    {
        [Test]
        public void Test1()
        {
            var expected = true;

            var board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},

                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },

                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var actual = Program.IsValidSudoku(board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = false;

            var board = new char[][]
            {
                new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},

                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },

                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var actual = Program.IsValidSudoku(board);

            Assert.AreEqual(expected, actual);
        }
    }
}
