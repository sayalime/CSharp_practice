using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5)Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for
             * casting his/her own vote.*/
            Console.WriteLine("Enter Your Age");
            int age =Convert.ToInt32 (Console.ReadLine());

            String res=age >= 18 ? "The Candidtate is Eligible for vote " : "The Candidtate is Not Eligible for vote ";
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
