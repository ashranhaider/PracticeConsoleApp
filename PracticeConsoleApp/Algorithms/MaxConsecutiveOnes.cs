using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    //Given a binary array nums (containing only 0 and 1), return the maximum number of consecutive 1s in the array.
    // Example 0101100111 = 3
    public static class MaxConsecutiveOnesCode
    {
        public static int MaxConsecutiveOnes(int[] nums) 
        {
            int maxCount = 0;
            int Count = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    Count++; 
                    
                    if (Count > maxCount)
                    {
                        maxCount = Count;
                    }
                }
                else
                {                    
                    Count = 0;
                }
            }

            return maxCount;
        }
    }
}
