using System;

namespace Parent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.SetAge(20);
            student.ShowAge();
            student.GoToClasses();

            Teacher teacher = new Teacher("java");
            teacher.SetAge(50);
            teacher.ShowAge();
            teacher.Explain();

            Console.ReadKey();
        }
    }
}
