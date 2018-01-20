using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms
{
    public class Week1Algorithms
    {
        public void SumOfTwoDigits()
        {
            var abString = Console.ReadLine();
            var abInt = abString.Split(" ");
            var result = AddTwoNumbers(Convert.ToInt32(abInt[0]), Convert.ToInt32(abInt[1]));
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }

        public void SumOfTwoDigitsFancy()
        {
            const string exit = "e";
            string input = String.Empty;
            do
            {
                Console.WriteLine("Enter two single digit integers, Press E to exit any time...");
                input = Console.ReadLine().ToLower();
                if (input != exit)
                {
                    int a = Convert.ToInt32(input);
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The sum of {a} and {b} is {AddTwoNumbers(a, b)}");
                }
            } while (input != exit);
        }

        public void MaximumPairwiseProduct()
        {
            var numberOfDigits = Console.ReadLine();
            string[] digitsInStrings = Console.ReadLine().Split(" ");
            int[] digits = digitsInStrings.Select(i => Convert.ToInt32(i)).ToArray();
            var maxProduct = GetMaxProduct(digits);
            Console.WriteLine($"{maxProduct}");
            Console.ReadLine();
        }

        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public int GetMaxProduct(int[] integers)
        {
            var sorted = integers.OrderByDescending(i => i).ToArray();
            return sorted[0] * sorted[1];
        }

    }
}
