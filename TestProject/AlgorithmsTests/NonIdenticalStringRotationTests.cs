using PracticeConsoleApp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class NonIdenticalStringRotationTests
    {
        [Fact]
        public void Returns_True_When_NonIdentical_Rotation_Exists()
        {
            // Arrange
            string s1 = "abcde";
            string s2 = "cdeab";

            // Act
            bool result = NonIdenticalStringRotation.isNonTrivialRotation(s1, s2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Returns_False_When_Strings_Are_Identical()
        {
            // Arrange
            string s1 = "abcde";
            string s2 = "abcde";

            // Act
            bool result = NonIdenticalStringRotation.isNonTrivialRotation(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Returns_False_When_Not_A_Rotation()
        {
            // Arrange
            string s1 = "abcde";
            string s2 = "edcba"; // anagram but not rotation

            // Act
            bool result = NonIdenticalStringRotation.isNonTrivialRotation(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Returns_False_When_Lengths_Are_Different()
        {
            // Arrange
            string s1 = "abcde";
            string s2 = "abcd";

            // Act
            bool result = NonIdenticalStringRotation.isNonTrivialRotation(s1, s2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Returns_True_For_Single_Left_Rotation()
        {
            // Arrange
            string s1 = "water";
            string s2 = "aterw";

            // Act
            bool result = NonIdenticalStringRotation.isNonTrivialRotation(s1, s2);

            // Assert
            Assert.True(result);
        }
    }
}
