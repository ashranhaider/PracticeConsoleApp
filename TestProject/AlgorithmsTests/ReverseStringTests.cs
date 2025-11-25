using PracticeConsoleApp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class ReverseStringTests
    {
        [Fact]
        public void ReverseString_ReturnsEmpty_WhenInputIsEmpty()
        {
            Assert.Equal("", ReverseStringCode.ReverseString(""));
        }

        [Fact]
        public void ReverseString_ReturnsSame_WhenSingleCharacter()
        {
            Assert.Equal("a", ReverseStringCode.ReverseString("a"));
        }

        [Fact]
        public void ReverseString_ReversesSimpleWord()
        {
            Assert.Equal("olleh", ReverseStringCode.ReverseString("hello"));
        }

        [Fact]
        public void ReverseString_ReversesPalindrome()
        {
            Assert.Equal("madam", ReverseStringCode.ReverseString("madam"));
        }

        [Fact]
        public void ReverseString_ReversesStringWithSpaces()
        {
            Assert.Equal("dlrow olleh", ReverseStringCode.ReverseString("hello world"));
        }

        [Fact]
        public void ReverseString_HandlesWhitespaceOnly()
        {
            Assert.Equal("   ", ReverseStringCode.ReverseString("   "));
        }

        [Fact]
        public void ReverseString_ReversesStringWithSpecialCharacters()
        {
            Assert.Equal("!cba", ReverseStringCode.ReverseString("abc!"));
        }

        [Fact]
        public void ReverseString_ReturnsNull_WhenInputIsNull()
        {
            Assert.Equal("", ReverseStringCode.ReverseString(null));
        }
    }
}
