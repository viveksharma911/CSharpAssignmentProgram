using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class PrimeNumberSolution
    {
        public bool isPrime(int inputNumber)
        {
            bool primeNumber = true;
            if (inputNumber == 1)
            {
                return primeNumber;
            }

            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    primeNumber = false;
                }

            }

            return primeNumber;
        }
    }

}

