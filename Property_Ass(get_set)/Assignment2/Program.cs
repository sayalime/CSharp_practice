using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }

            public void Display()
            {
               
                   Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int no_of_students = Convert.ToInt32(Console.ReadLine());

            Student[] stud = new Student[no_of_students];

            for (int i = 0; i < no_of_students; i++)
            {
                Console.Write($"Enter details for Student\n");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("GPA: ");
                double gpa = Convert.ToDouble(Console.ReadLine());

                stud[i] = new Student { Name = name, Age = age, GPA = gpa };
            }

            Console.WriteLine("Student Details:");
            foreach (var student in stud)
            {
                student.Display();
            }Console.ReadKey();

        }
    }

    
}
