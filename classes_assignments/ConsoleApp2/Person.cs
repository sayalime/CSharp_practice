using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        private int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old.");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
