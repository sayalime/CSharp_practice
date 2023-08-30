using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        //1. Write C# code to declare and initialize a List of integers named "numberList". Add the following numbers to
        //the list: 10, 20, 30, 40, and 50. Finally, print all the elements of the list.
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 10,20,30,40,50};
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
