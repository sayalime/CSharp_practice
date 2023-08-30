using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_por2
{
    internal class Program
    {
//Write a C# program to search for a specific element in a given integer array of size 6. If the element is found, 
//display its index; otherwise,display "Element not found."
        public static int getInput(int no)
        {
            return no;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6};
            int no = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <6; i++)
            {
                if (no== i)
                {
                    Console.WriteLine($"Number found at Index {i}", arr[i] );
                }
                Console.WriteLine($"Number not found at Index {i}", arr[i]);
            }
            getInput(no);

            Console.ReadKey();

        }
    }
}
