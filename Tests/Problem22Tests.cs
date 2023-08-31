using Leetcode.Problem22;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Problem22Tests
    {
        [Test]
        public void Test1()
        {
            var expected = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };

            var n = 3;

            var actual = Program.GenerateParenthesis(n);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = new List<string>() { "()" };

            var n = 1;

            var actual = Program.GenerateParenthesis(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
