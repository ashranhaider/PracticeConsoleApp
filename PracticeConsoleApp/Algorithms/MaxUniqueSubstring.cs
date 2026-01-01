using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class MaxUniqueSubstring
    {
        public static int MaxDistinctSubstringLengthInSessions(string sessionString)
        {
            if (string.IsNullOrEmpty(sessionString))
                return 0;

            int left = 0;
            int maxLen = 0;
            Dictionary<char, int> seen = new();

            for (int right = 0; right < sessionString.Length; right++)
            {
                char c = sessionString[right];

                if (c == '*')
                {
                    // session break
                    maxLen = Math.Max(maxLen, right - left);
                    seen.Clear();
                    left = right + 1;
                    continue;
                }

                if (seen.ContainsKey(c) && seen[c] >= left)
                {
                    // duplicate found -> move left right after previous index
                    left = seen[c] + 1;
                }

                // update last seen index
                seen[c] = right;

                maxLen = Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
        }

    }
}
