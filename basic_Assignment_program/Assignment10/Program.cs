using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10)Write a C# Sharp program to find the sum of the first 10 natural numbers.
            int n = 10; 
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum of the first 10 natural numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
