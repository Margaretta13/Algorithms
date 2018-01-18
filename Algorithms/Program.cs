using System;

namespace Algorithms
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    const string exit = "e";
        //    string input = String.Empty;
        //    do
        //    {
        //        Console.WriteLine("Enter two single digit integers, Press E to exit any time...");
        //        input = Console.ReadLine().ToLower();
        //        if (input != exit)
        //        {
        //            int a = Convert.ToInt32(input);
        //            int b = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        //        }
        //    } while (input != exit);
        //}

        //week 1 - 1
        static void Main(string[] args)
        {
            var abString = Console.ReadLine();
            var abInt = abString.Split(" ");
            Console.WriteLine($"{Convert.ToInt32(abInt[0]) + Convert.ToInt32(abInt[1])}");
            Console.ReadLine();
        }
        
    }
}
