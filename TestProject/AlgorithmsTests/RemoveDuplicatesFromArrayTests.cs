using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    using PracticeConsoleApp.Algorithms;
    using Xunit;

    public class RemoveDuplicatesTests
    {
        private readonly RemoveDuplicatesFromArray _solution = new RemoveDuplicatesFromArray();

        [Fact]
        public void RemoveDuplicates_SingleElement_ReturnsOne()
        {
            int[] nums = { 1 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(1, k);
            Assert.Equal(new[] { 1 }, nums[..k]);
        }

        [Fact]
        public void RemoveDuplicates_AllUnique_ReturnsFullLength()
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(5, k);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, nums[..k]);
        }

        [Fact]
        public void RemoveDuplicates_AllDuplicates_ReturnsOne()
        {
            int[] nums = { 2, 2, 2, 2 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(1, k);
            Assert.Equal(new[] { 2 }, nums[..k]);
        }

        [Fact]
        public void RemoveDuplicates_MixedDuplicates_RemovesCorrectly()
        {
            int[] nums = { 1, 1, 2 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(2, k);
            Assert.Equal(new[] { 1, 2 }, nums[..k]);
        }

        [Fact]
        public void RemoveDuplicates_LeetCodeExample_RemovesCorrectly()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(5, k);
            Assert.Equal(new[] { 0, 1, 2, 3, 4 }, nums[..k]);
        }

        [Fact]
        public void RemoveDuplicates_WithNegativeNumbers_WorksCorrectly()
        {
            int[] nums = { -3, -3, -1, -1, 0, 0, 2 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(4, k);
            Assert.Equal(new[] { -3, -1, 0, 2 }, nums[..k]);
        }
    }

}
