using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class NonIdenticalStringRotation
    {
        public static bool isNonTrivialRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            if (s1 == s2)
                return false;

            string temp = s1 + s1;
            return temp.Contains(s2);
        }

    }
}
