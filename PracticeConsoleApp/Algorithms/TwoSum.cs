using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 You are given an array of integers and a target value. Return indices of the two numbers such that they add up to the target.
 */

namespace PracticeConsoleApp.Algorithms
{

    public static class TwoSum
    {
        public static int[] FindTwoSum_NestedLoops(int[] nums, int target)
        {
            List<int> RequiredIndexes = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException("No two sum solution exists for the given input.");
        }
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> processedNumbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
               int OtherNumber = target - nums[i];

                if(processedNumbers.ContainsKey(OtherNumber))
                {
                    return new int[] { processedNumbers[OtherNumber], i };
                }
                else
                {
                    processedNumbers.Add(nums[i], i);
                }
            }

            throw new ArgumentException("No two sum solution exists for the given input.");
        }
    }
}
