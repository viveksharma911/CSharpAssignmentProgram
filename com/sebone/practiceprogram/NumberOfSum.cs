using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class NumberOfSum
    {

       public int getSum(int number)
        {
           int sumNumber=  0;

            for(int i=0; i<=number; i++)
            {
                sumNumber += i ;
            }

           return sumNumber;
        }

        
    }
}
