using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Logical Programming");
            Console.WriteLine("Program #1: Fibonacci Series");
            Console.WriteLine("Program #2: Perfect Numbers");
            Console.WriteLine("Program #3: Prime Numbers");
            Console.WriteLine("Program #4: Reverse A Number");
            Console.WriteLine("Program #5: Coupon Numbers");
            Console.WriteLine("Program #6: Stopwatch Simulator");

            Console.Write("\nPlease select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    fibonacci.UC1();
                    break;
                case 2:
                    perfectNumber.UC2();
                    break;
                case 3:
                    primeNumber.UC3();
                    break;
                case 4:
                    reverseNumber.UC4();
                    break;
                case 5:
                    couponNumber.UC5();
                    break;
                case 6:
                    stopWatch.UC6();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
            Console.ReadKey();
        }
    }
}
