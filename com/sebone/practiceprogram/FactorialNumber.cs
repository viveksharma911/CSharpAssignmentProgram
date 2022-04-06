using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class FactorialNumber
    {
        public int getFactorial(int number)
        {
            int factorial = 1; 
            
            for(int i = number; i >0; i--)
            {
                factorial *= i;
            }
            return factorial;   
        }
        

        
    }
}
