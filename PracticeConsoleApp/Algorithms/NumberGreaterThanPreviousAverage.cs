using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Count Elements Greater Than Previous Average
Given an array of positive integers, return the number of elements that are strictly greater than the average of all previous elements. Skip the first element.

Example

Input

responseTimes = [100, 200, 150,300]
Output

2
Explanation

- Day 0: 100 (no previous days, skip) 
- Day 1: 200 > average(100) = 100 → count = 1 
- Day 2: 150 vs average(100, 200) = 150 → not greater → count = 1 
- Day 3: 300 > average(100, 200, 150) = 150 → count = 2  
 */

namespace PracticeConsoleApp.Algorithms
{
    public class NumberGreaterThanPreviousAverage
    {
        public static int countResponseTimeRegressions(List<int> responseTimes)
        {
            int totalNumbersFound = 0;

            for (int i = 1; i < responseTimes.Count; i++)
            {
                long sum = 0;
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    sum = sum + responseTimes[j];
                    count++;
                }
                double average = sum / count;
                if (responseTimes[i] > average)
                {
                    totalNumbersFound++;
                }

            }


            return totalNumbersFound; // Placeholder return statement
        }
    }
}
