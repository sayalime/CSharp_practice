using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6)Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
            Console.WriteLine("Enter Your Height");
            Double height = Convert.ToDouble(Console.ReadLine());
            string res =  (height < 150) ? "Short"
                            : (height >= 150 && height < 170) ? "Average"
                            : (height >= 170 && height < 190) ? "Tall"
                            : "Very tall";
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
