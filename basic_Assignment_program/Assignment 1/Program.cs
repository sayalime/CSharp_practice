using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1)Write a C# Sharp program to accept two integers and check whether they are equal or not.*/
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} : is equal to : {b}");
            }
            else
            {
                Console.WriteLine($"{a} : is not equal to : {b}");

            }
            Console.ReadLine();
        }
    }
}
