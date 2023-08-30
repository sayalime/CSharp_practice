using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_probs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to read n values in an array and display them in reverse order.
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = size; i >0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
