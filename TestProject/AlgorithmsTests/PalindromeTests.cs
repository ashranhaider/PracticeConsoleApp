using PracticeConsoleApp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("A1b2B!a", 1)]
        [InlineData("abc123cba", 1)]
        [InlineData("Z", 1)]
        [InlineData("!!@@##", 1)]   // no letters → empty → palindrome
        [InlineData("", 1)]
        [InlineData("a", 1)]
        [InlineData("ab", 0)]
        [InlineData("No1oN", 1)]
        [InlineData("Hello!", 0)]
        public void IsFilteredPalindrome_ShouldReturnExpectedResult(string input, int expected)
        {
            // Act
            int result = Palindrome.IsFilteredPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
