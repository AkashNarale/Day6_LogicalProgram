using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class perfectNumber
    {
        //program for perfect number
        public static void UC2()
        {
            int sum = 0;
            int num = 0;
            //taking input from user
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (num == sum)
            {
                Console.WriteLine("{0} is a perfect number.", +num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number.", +num);
            }
        }
    }
}
