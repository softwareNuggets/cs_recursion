using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class StringReverse
    {

        public void ReverseStringExample()
        {
            string input = "abcd";
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);
        }

        private string ReverseString(String str)
        {

            if (str.Length == 0)                         // stop condition 
            {
                return "";
            }

            var s = str[str.Length - 1];                // get the last character
                                                        // stack frame
                                                        // use as variable on line 44


            var s2 = str.Substring(0, str.Length - 1);  // build s2 to use as parameter 

            var x = ReverseString(s2);                  // recursively use s2
                                                        // recursion creates stack frame 

            return s + x;

        }
    }
}
