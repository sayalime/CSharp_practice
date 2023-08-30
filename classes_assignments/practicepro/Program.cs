using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practicepro
{
    internal class Program
    {
        /*Write a C# program to initialize an integer array of size 5 and populate it with values entered by the user. 
        Then, print the elements of the array in reverse order.*/
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter values");
            for (int i = 0; i < 5; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse List");
            for (int i = 5-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);

            }
            Console.ReadKey();

        }
    }
}
