using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static int FindLargest(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is largest");
                }
                else
                {
                    Console.WriteLine("c is largest");
                }
            }
            else
            {
                Console.WriteLine("b is largest");
            }

            return 0;
        }

        static int FindLowest(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine("a is lowest");
                }
                else
                {
                    Console.WriteLine("c is lowest");
                }
            }
            else
            {
                Console.WriteLine("b is lowest");
            }

            return 0;
        }
        static void Main(string[] args)
        {
            //9)Write a C# program to find the largest and lowest values from three integer values.
            Console.WriteLine("Enter three integers:");

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());

            FindLargest(n1, n2, n3);
            FindLowest(n1, n2, n3);
            Console.ReadLine();
        }
    }
}

