using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class primeNumber
    {
        //program for prime numbers
        public static void UC3()
        {
            int a = 0;
            //taking input from user
            Console.WriteLine("Enter a number to check prime:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number", +num);
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("{0} is a prime number", +num);
            }
        }
    }
}
