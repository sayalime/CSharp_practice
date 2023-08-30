using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacherTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHello();
            Student s = new Student();
            s.SetAge(21);
            s.SayHello();
            s.ShowAge();
            Teacher t = new Teacher("C#");
            t.SetAge(30);
            t.SayHello();
            t.Explain();
            Console.ReadKey();
        }
    }
}
