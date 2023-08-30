using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2)Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2==0)
            {
                Console.WriteLine($"{a} : is Even Number");
            }
            else
            {
                Console.WriteLine($"{a} : is odd number");

            }
            Console.ReadLine();
        }
    }
}
