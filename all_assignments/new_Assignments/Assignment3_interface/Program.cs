using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.get("Sayali");
            student.Display();
            Console.ReadKey();
        }
    }
}
