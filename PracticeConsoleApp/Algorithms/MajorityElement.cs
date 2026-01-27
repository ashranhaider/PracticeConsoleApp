using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class MajorityElement
    {
        public static int FindMajorityElement(int[] nums)
        {
            Dictionary<int,int> data = new Dictionary<int, int>();
            int candidate = -1;
            
            foreach(var num in nums)
            {
                if (data.ContainsKey(num))
                {
                    data[num]++;
                }
                else
                {
                    data.Add(num, 1);
                }
            }
            int highestFrequency = 0;
            foreach (var datanum in data)
            {
                if (datanum.Value > highestFrequency)
                {
                    candidate = datanum.Key;
                    highestFrequency = datanum.Value;
                }
            }
            return candidate;
        }
        // Boyer–Moore algorithm
        public static int FindMajorityElement2(int[] nums)
        {
            int count = 0;
            int candidate = -1;

            foreach (var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            return candidate;
        }
    }
}
