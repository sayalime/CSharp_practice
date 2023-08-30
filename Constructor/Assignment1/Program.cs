using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {

        //Write a C# program that accepts a distance in kilometers, converts it into meters, and then displays the result.
        int input;

        public void display(int input)
        {
            this.input = input;
            input *= 1000;
            Console.WriteLine(input);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in kilomters");
            int input = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.display(input);
            Console.ReadKey();
        }
    }
}
