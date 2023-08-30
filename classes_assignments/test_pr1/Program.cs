using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pr1
{
    internal class Program
    {
        //write a program to print even and odd numbers from 1 to 100

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int no = Convert.ToInt32(Console.ReadLine());
            parent p = new parent();
            p.getinput(no);

            child c = new child();
            c.EvenOdd(no);
          
            Console.ReadKey();


           

        }
    }
}
