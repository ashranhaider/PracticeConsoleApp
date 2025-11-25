using PracticeConsoleApp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class MaxConsecutiveOnesTests
    {
        /*
            * Goal: Given a binary array, return the maximum number of consecutive 1s.
            * Time: O(n) single pass. Space: O(1).
        */

        [Theory]
        [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(new int[] { 1, 0, 1, 1, 0, 1 }, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 4)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        public void Returns_Max_Streak_Of_Ones(int[] nums, int expected)
        {
            var actual = MaxConsecutiveOnesCode.MaxConsecutiveOnes(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Handles_Streak_At_Array_End()
        {
            var nums = new[] { 0, 1, 1, 0, 1, 1, 1 };
            var actual = MaxConsecutiveOnesCode.MaxConsecutiveOnes(nums);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Handles_Streak_At_Array_Start()
        {
            var nums = new[] { 1, 1, 1, 0, 1, 0 };
            var actual = MaxConsecutiveOnesCode.MaxConsecutiveOnes(nums);
            Assert.Equal(3, actual);
        }
    }
}
