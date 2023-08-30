using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parent
{
    internal class StudentAndTeacherTest
    {
        public static void Main (String[] args)
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
