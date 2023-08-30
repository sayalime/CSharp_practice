using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_polymorphism
{
    interface Person
    {
         void get(string name);
    }
    class Student : Person
    {
        string name;
        

        public void get(string name)
        {
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(this.name);
        }
    }
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
