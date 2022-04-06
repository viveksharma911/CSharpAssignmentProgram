using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class AnagramSolution
    {
      public  bool isAngramn(String firstString, String secondString)
        {
            if (firstString.Length !=  secondString.Length) return false;

            bool flag = true;
            char[] firstInput = firstString.ToCharArray();
            char[] secondInput = secondString.ToCharArray();
            Array.Sort(firstInput);    
            Array.Sort(secondInput);  
            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] != secondInput[i])
                {
                    flag = false;
                }
               
            }
            return flag;    
        }
    }
}
