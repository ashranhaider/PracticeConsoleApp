using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    public class MajorityElementTests
    {
        [Fact]
        public void TestFindMajorityElement()
        {
            // Arrange
            int[] nums = new int[] { 3, 2, 3 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestFindMajorityElement2()
        {
            // Arrange
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestFindMajorityElement3_SingleElement()
        {
            // Arrange
            int[] nums = new int[] { 10 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void TestFindMajorityElement4_AllSame()
        {
            // Arrange
            int[] nums = new int[] { 5, 5, 5, 5, 5 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestFindMajorityElement5_NegativeNumbers()
        {
            // Arrange
            int[] nums = new int[] { -1, -1, -1, 2, 3 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestFindMajorityElement6_MinimumMajorityThreshold()
        {
            // Arrange
            int[] nums = new int[] { 4, 4, 4, 2, 3 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestFindMajorityElement7_LargeValues()
        {
            // Arrange
            int[] nums = new int[] { int.MaxValue, 1, int.MaxValue, int.MaxValue };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void TestFindMajorityElement8_MinIntValues()
        {
            // Arrange
            int[] nums = new int[] { int.MinValue, int.MinValue, 5 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void TestFindMajorityElement9_ShuffledOrder()
        {
            // Arrange
            int[] nums = new int[] { 7, 1, 7, 2, 7, 3, 7 };
            // Act
            int result = PracticeConsoleApp.Algorithms.MajorityElement.FindMajorityElement(nums);
            // Assert
            Assert.Equal(7, result);
        }
    }

}
