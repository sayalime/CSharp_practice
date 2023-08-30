using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {// encapsulation in OOP.

        static void Main(string[] args)
        {
           Student student = new Student();
            student.Stud_id = 1;
            Console.WriteLine(student.Stud_id);
            student.Name("Sayali");
            Console.WriteLine(student.GetName);
            student.SetAge(22);
            Console.WriteLine(student.GetAge);
            student.Location = "Pune";
            Console.WriteLine(student.Location);

            Console.ReadKey();

        }
    }
}
