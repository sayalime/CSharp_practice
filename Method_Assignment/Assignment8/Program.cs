using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        //create a program that uses recursion to calculate a number in the fibonacci series 
        static int fibrecursive(int no)
        {
            if (no <= 1)
                return no;
            return fibrecursive(no - 1) + fibrecursive(no - 2);
        }
        static void fibprint(int no)
        {

            for (int i = 0; i < no; i++)
            {

                Console.WriteLine("index {0}: {1}", i, fibrecursive(i));
            }

        }
        static void Main(string[] args)
        {
            fibprint(10);
            Console.ReadLine();
        }
    }
}
