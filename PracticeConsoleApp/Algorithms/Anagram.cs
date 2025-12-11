using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class Anagram
    {
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null || str2 == null) return false;
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                if (!freq.TryGetValue(c, out int count))
                    freq[c] = 1;
                else
                    freq[c] = count + 1;
            }

            foreach (char c in str2)
            {
                if (!freq.TryGetValue(c, out int count))
                    return false;

                count--;

                if (count < 0)
                    return false;

                freq[c] = count;
            }

            return true;
        }

    }
}
