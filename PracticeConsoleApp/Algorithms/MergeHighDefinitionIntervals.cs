using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class MergeHighDefinitionIntervals
    {
        public static List<List<int>> mergeHighDefinitionIntervals(List<List<int>> intervals)
        {
            var sortedIntervals = new List<List<int>>();
            if (intervals.Count == 0)
                return sortedIntervals;

            // step 1: sort intervals
            intervals = intervals.OrderBy(x => x[0]).ToList();

            int first = intervals[0][0];
            int second = intervals[0][1];

            for (int i = 1; i < intervals.Count; i++)
            {
                int start = intervals[i][0];
                int end = intervals[i][1];

                // Overlap condition:
                if (start <= second)
                {
                    // Extend interval
                    second = Math.Max(second, end);
                }
                else
                {
                    // Push merged interval
                    sortedIntervals.Add(new List<int> { first, second });

                    // Reset window
                    first = start;
                    second = end;
                }
            }

            // push last window
            sortedIntervals.Add(new List<int> { first, second });

            return sortedIntervals;
        }

    }
}
