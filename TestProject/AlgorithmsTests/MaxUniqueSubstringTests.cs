using PracticeConsoleApp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class MaxUniqueSubstringTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("abc*abc*abcbb", 3)]
        [InlineData("abca*bcd*xyz", 3)]
        [InlineData("aaa*abcd*bb", 4)]
        [InlineData("*abc", 3)]
        [InlineData("abc*", 3)]
        [InlineData("aaaa", 1)]
        [InlineData("", 0)]
        [InlineData("***", 0)]
        [InlineData("abca*xyzabcd*aaaa*bcdxyz", 7)]
        public void MaxDistinctSubstringLengthInSessions_ShouldReturnCorrectResult(string input, int expected)
        {
            int result = MaxUniqueSubstring.MaxDistinctSubstringLengthInSessions(input);
            Assert.Equal(expected, result);
        }


        // Optional additional crystal-clear unit tests for edge behavior:

        [Fact]
        public void ShouldHandleBasicUniqueString()
        {
            int result = MaxUniqueSubstring.MaxDistinctSubstringLengthInSessions("abcbde");
            Assert.Equal(4, result);
        }

        [Fact]
        public void ShouldHandleSingleCharCorrectly()
        {
            int result = MaxUniqueSubstring.MaxDistinctSubstringLengthInSessions("a");
            Assert.Equal(1, result);
        }

        [Fact]
        public void ShouldReturnZeroWhenOnlyStars()
        {
            int result = MaxUniqueSubstring.MaxDistinctSubstringLengthInSessions("***");
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldHandleLongUniqueString()
        {
            int result = MaxUniqueSubstring.MaxDistinctSubstringLengthInSessions("abcdefghijklmnopqrstuvwxyz");
            Assert.Equal(26, result);
        }
    }
}
