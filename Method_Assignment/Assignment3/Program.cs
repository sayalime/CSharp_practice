using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //write a program in c# to create a function for the sum of two numbers
    internal class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter values");
            int s = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int res = sum(s, c);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
