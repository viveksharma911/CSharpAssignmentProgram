using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class ReverseString
    {
        public String getsStringReverse(String inputString)
        {
            String reverseString = "";
            for(int i = inputString.Length-1; i >= 0; i--)
            {
                reverseString += inputString[i];
            }
            return reverseString;
        }
    }
}
