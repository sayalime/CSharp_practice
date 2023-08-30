using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.put_details(1, "sayali", "Pawar");
            student.put_details(22);
            student.display();
            Console.ReadKey();

        }
    }
}
