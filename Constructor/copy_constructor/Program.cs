using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    internal class Program
    {
        //In c#, Copy Constructor is a parameterized constructor that contains a parameter of the same class type. The copy constructor
        // in c# is useful whenever we want to initialize a new instance to the values of an existing instance.
        int age;
        public Program()
        {
            int age = 21;
            string name = "Sayali";
            string location = "Pune";
            Console.WriteLine("default constructor " + age);
            Console.WriteLine("default constructor " + name);
            Console.WriteLine("default constructor " + location);
        }
        public Program(Program age,Program name)
        {
            age = Program.age;
        } 
        static void Main(string[] args)
        {
        }
    }
}
