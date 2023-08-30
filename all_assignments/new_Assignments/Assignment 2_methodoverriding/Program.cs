using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_methodoverriding
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person person = new Person();
            person.display();

           Teacher teacher = new Teacher();
            teacher.get_data(1, "Raj", "shinde");
            teacher.display();
            teacher.check();

            Student student = new Student();
            student.get_data(1, "Ram", "aaa");
            student.display();
            student.check();
            Console.ReadKey();

        }
    }
}
