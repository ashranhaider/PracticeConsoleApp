using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class Palindrome
    {
        public static int IsFilteredPalindrome(string code)
        {
            if (string.IsNullOrEmpty(code))
                return 1;

            StringBuilder filtered = new StringBuilder("");

            foreach (char c in code)
            {
                if (Char.IsLetter(c))
                {
                    filtered.Append(Char.ToLower(c));
                }
            }

            if (filtered.Length == 0)
            {
                return 1;
            }

            int right = filtered.Length - 1;

            for(int i = 0; i < filtered.Length; i++) 
            {
                if (filtered[i] != filtered[right])
                {
                    return 0;
                }

                if(i >= right)
                {
                    break;
                }
                right--;
            }
            return 1;
        }
    }
}
