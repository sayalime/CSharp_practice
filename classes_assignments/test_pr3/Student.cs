using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pr3
{
    internal class Student
    {
        public Student()
        {
            Console.WriteLine("I'm a Default constructor");
        }
        public Student(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
