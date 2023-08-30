using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //write a program in c# to create a function to swap the two integers
    internal class Program
    {
        static void swapdigits(int a, int b)
        {
            Console.WriteLine("before swapping a value : " + a);
            Console.WriteLine("before swapping b value : " + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping a value : " + a);
            Console.WriteLine("after swapping b value : " + b);
        }
        static void Main(string[] args)
        {
            swapdigits(2, 4);
            Console.ReadKey();
        }
    }
}
