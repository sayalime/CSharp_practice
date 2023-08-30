using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Write a C# Sharp program to find out whether a given year is a leap year or not.
            Console.WriteLine("Enter year");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a%4==0 && a%100!=0 || a%400==0)
            {
                
                Console.WriteLine($"{a} : is leap year");
            }
            else
            {
                Console.WriteLine($"{a} : is not a leap year");

            }
            Console.ReadLine();
        }
    }
}
