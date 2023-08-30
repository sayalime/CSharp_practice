using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        //create a function named "Double" to calculate and return an integer number doubled 
        static int Double(int no)
        {
            int res = no * 2;
            return res;
        }
        static void Main(string[] args)
        {
            int res=Double(7);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
