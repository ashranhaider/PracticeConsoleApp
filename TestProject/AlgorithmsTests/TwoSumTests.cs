using PracticeConsoleApp.Algorithms;
namespace TestProject.AlgorithmsTests
{
    public class TwoSumTests
    {
        [Fact]
        public void Test_TwoNumbersAtBeginning()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Assert.Equal(new int[] { 0, 1 }, TwoSum.FindTwoSum(nums, target));
        }

        [Fact]
        public void Test_TwoNumbersInMiddle()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            Assert.Equal(new int[] { 1, 2 }, TwoSum.FindTwoSum(nums, target));
        }

        [Fact]
        public void Test_NegativeNumbersIncluded()
        {
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;
            Assert.Equal(new int[] { 2, 4 }, TwoSum.FindTwoSum(nums, target));
        }

        [Fact]
        public void Test_DuplicatesAllowed()
        {
            int[] nums = { 3, 3 };
            int target = 6;
            Assert.Equal(new int[] { 0, 1 }, TwoSum.FindTwoSum(nums, target));
        }

        [Fact]
        public void Test_BiggerArray()
        {
            int[] nums = { 1, 5, 3, 7, 9, 2 };
            int target = 11;
            Assert.Equal(new int[] { 4, 5 }, TwoSum.FindTwoSum(nums, target));
        }

        [Fact]
        public void Test_NoSolutionThrows()
        {
            int[] nums = { 1, 2, 3 };
            int target = 100;

            Assert.Throws<System.ArgumentException>(() => TwoSum.FindTwoSum(nums, target));
        }
    }
}
