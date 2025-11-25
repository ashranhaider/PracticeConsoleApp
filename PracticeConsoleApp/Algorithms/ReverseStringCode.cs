using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{
    public class ReverseStringCode
    {
        public static String ReverseString(String str)
        {
            if(str == null)
            {
                return String.Empty;
            }
            StringBuilder output = new StringBuilder(str.Length);
            for (int i = str.Length -1; i >= 0; i--)
            {
                output.Append(str[i]);
            }
            return output.ToString();
        }
    }
}
