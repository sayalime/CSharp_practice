using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    ////write a program in c# to create a function for the sum of elements in an array
    internal class Program
    {
        static int arrsum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arrr = { 3, 4, 5, 7 };
            int res=arrsum(arrr);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
