using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class RemoveDuplicatesFromArray
    {

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int write = 1;

            for (int read = 1; read < nums.Length; read++)
            {
                if (nums[read] == nums[read - 1])
                {
                    continue;
                }
                else
                {
                    nums[write] = nums[read];
                    write++;
                }
            }

            return write;
        }
    }
}
