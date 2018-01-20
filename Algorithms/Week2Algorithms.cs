using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithms
{
    public class Week2Algorithms
    {
        public void FibonacciNumber()
        {
            var number = Console.ReadLine();
            //var returned = FibonacciNaive(Convert.ToInt32(number));
            //var returned = FibonacciEfficiet(Convert.ToInt32(number));
            var returned = LastDigitOfFibonacci(Convert.ToInt32(number));
            Console.WriteLine($"{returned}");
            Console.ReadLine();
        }

        public int LastDigitOfFibonacci(int nthFibonacci)
        {
            var fibonacciNumbers = new int[nthFibonacci + 1];
            fibonacciNumbers[0] = 0;
            if (nthFibonacci > 0)
            {
                fibonacciNumbers[1] = 1;
                for (int i = 2; i <= nthFibonacci; i++)
                {
                    fibonacciNumbers[i] = (fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]) % 10;
                }
            }
            return fibonacciNumbers[nthFibonacci];
        }

        public void GreatestCommonDivisor()
        {
            var numbersStringsArray = Console.ReadLine().Split(" ");
            var firstNumber = Convert.ToInt32(numbersStringsArray[0]);
            var secondNumber = Convert.ToInt32(numbersStringsArray[1]);

            if (firstNumber < secondNumber)
            {
                var temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            //var returned = GreatestCommonDivisorNaive(firstNumber, secondNumber);
            var returned = GreatestCommonDivisorEfficient(firstNumber, secondNumber);
            Console.WriteLine($"{returned}");
            Console.ReadLine();
        }

        public void LeastCommonMultiple()
        {
            var numbersStringsArray = Console.ReadLine().Split(" ");
            var firstNumber = Convert.ToInt32(numbersStringsArray[0]);
            var secondNumber = Convert.ToInt32(numbersStringsArray[1]);

            if (firstNumber < secondNumber)
            {
                var temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            var returned = LeastCommonMultipleEfficient(firstNumber, secondNumber);
            Console.WriteLine($"{returned}");
            Console.ReadLine();
        }

        public int FibonacciModulo(int nthFibonacci, int mModulo)
        {
            var fibonacciModuloArray = FibonacciModuloArrayPeriodic(mModulo);

            int remainder = nthFibonacci % (fibonacciModuloArray.Count - 2);
            return fibonacciModuloArray[remainder];
        }



        public int FibonacciNaive(int n)
        {
            return n > 1 ? FibonacciNaive(n - 1) + FibonacciNaive(n - 2) : n;
        }

        public int FibonacciEfficiet(int n)
        {
            var fibonacciNumbers = new int[n + 1];
            fibonacciNumbers[0] = 0;
            if (n > 0)
            {
                fibonacciNumbers[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                }
            }
            return fibonacciNumbers[n];
        }

        public int GreatestCommonDivisorNaive(int firstNumber, int secondNumber)
        {
            var gcd = 0;
            for (int i = 1; i <= Math.Max(firstNumber, secondNumber); i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    gcd = i > gcd ? i : gcd;
                }
            }

            return gcd;
        }

        public int GreatestCommonDivisorEfficient(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                return firstNumber;
            }

            return GreatestCommonDivisorEfficient(secondNumber, firstNumber % secondNumber);
        }

        public int LeastCommonMultipleEfficient(int largerNumber, int smallerNumber)
        {
            if (largerNumber % smallerNumber == 0)
            {
                return largerNumber;
            }
            var gcd = GreatestCommonDivisorEfficient(largerNumber, smallerNumber);
            return gcd * (largerNumber / gcd) * (smallerNumber / gcd);
        }

        public List<int> FibonacciModuloArrayPeriodic(int mModulo)
        {
            List<int> fibonacciModuloLists = new List<int>();
            fibonacciModuloLists.Add(0);
            fibonacciModuloLists.Add(1);
            fibonacciModuloLists.Add(1);
            var i = 3;

            while (!(fibonacciModuloLists.Last() == 1 && fibonacciModuloLists[fibonacciModuloLists.Count - 2] == 0))
            {
                fibonacciModuloLists.Add(FibonacciEfficiet(i) % mModulo);
                i++;
            }

            return fibonacciModuloLists;
        }

    }
}
