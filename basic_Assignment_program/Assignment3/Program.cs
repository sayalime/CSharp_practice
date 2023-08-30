using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3)Write a C# Sharp program to check whether a given number is positive or negative.
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a} : is Positive Number");
            }
            else
            {
                Console.WriteLine($"{a} : is Negative number");

            }
            Console.ReadLine();
        }
    }
}
