using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharpProgram.CSProgram
{
    internal class TwoSumSolution
    {

         public bool checkTwoSum(int targetValue , int[] inputArray)
        {   bool flag = false;
            for(int i = 0; i < inputArray.Length-1; i++)
            {
                for(int j=i;j< inputArray.Length; j++)
                {
                    if(inputArray[i]+inputArray[j] == targetValue)
                    {
                        flag = true; 
                    }
                }
            }
            return flag ;
        }



        static void Main(String[] arg)
        {
            AnagramSolution anagramSolution = new AnagramSolution();
            NumberOfSum numberOfSum = new NumberOfSum();
            TwoSumSolution twoSumSolution = new TwoSumSolution();
            FactorialNumber factorialNumber = new FactorialNumber();
            ReverseString reverseString = new ReverseString();
            PrimeNumberSolution primeNumberSolution = new PrimeNumberSolution();

            int num = Convert.ToInt32( Console.ReadLine());

            switch (num)
            {
                case 1:
                    String str1 = Console.ReadLine();
                    String str2 = Console.ReadLine();
                    bool flag2 = anagramSolution.isAngramn(str1, str2);
                    Console.WriteLine(flag2);
                    break;
            }
            switch (num)
            {
                case 2:
                    int targetValue1 = Convert.ToInt32(Console.ReadLine());
                    int ans1 = factorialNumber.getFactorial(targetValue1);
                    Console.WriteLine(ans1);
                    break;
            }
            switch(num)
            {
                case 3:

                    int targetValue = Convert.ToInt32(Console.ReadLine());
                    int ans = numberOfSum.getSum(targetValue);
                    Console.WriteLine(ans);
                   
                    break;
            }
            switch (num)
            {
                case 4:

                    int targetValue = Convert.ToInt32(Console.ReadLine());
                    int[] inputArray = { 1, 2, 3, 4, 5 };
                  
                    bool flag = twoSumSolution.checkTwoSum(targetValue, inputArray);
                    Console.WriteLine(flag);    

                    break;

            }
            switch (num)
            {
                case 5:
                    
                    String inputString = Console.ReadLine();
                    String finalString = reverseString.getsStringReverse(inputString);
                    Console.WriteLine(finalString);
                    break;
            
            }

            switch (num)
            {
                case 6:
                    
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    bool flag = primeNumberSolution.isPrime(inputNumber);
                    Console.WriteLine(flag);
                    break;
            }
                







        }

    }
}
