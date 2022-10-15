using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class reverseNumber
    {
        //program for reverse number
        public static void UC4()
        {
            int x = 0, y = 0;
            Console.WriteLine("Enter a number to reverse :");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                x = num % 10;
                y = y * 10 + x;
                num = num / 10;
            }
            Console.WriteLine("The reverse of the giver number is :" +y);
        }
    }
}
