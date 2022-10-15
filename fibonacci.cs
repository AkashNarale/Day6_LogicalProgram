using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class fibonacci
    {
        //program for fibonacci
        public static void UC1()
        {
            int res;
            //taking input from user
            Console.WriteLine("Enter two numbers :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            //int num1=0;
            //int num2=1;

            //asking till what count we want
            Console.WriteLine("Enter tthe count :");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                res = num1 + num2;
                Console.WriteLine(res + " ");
                num1 = num2;
                num2 = res;
            }
        }
    }
}
