using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_methodoverriding
{
    public  class Person
    {
        public void check()
        {
            Console.WriteLine("base class");
        }
        public virtual void display()
        {
            Console.WriteLine("This is base class ");
        }
    }
        public class Student : Person
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public virtual void get_data(int id,string firstname,string lastname)
            {
                Id=id;
                FirstName=firstname;
                LastName=lastname;

            }
            public override void display()
            {
                Console.WriteLine($"Student Id : {Id}   \n Student First name : " +
                    $"{FirstName} \n Student Last Name : {LastName}  ");
            }
        }
        public class Teacher : Student
        {
            public override void get_data(int id,  string firstname, string lastname)
            {
                Id = id;
                FirstName = firstname;
                LastName = lastname;

            }
            public  override void display()
            {
                Console.WriteLine($"Teacher Id : {Id}  \n Teacher First name : " +
                    $"{FirstName} \n Teacher Last Name : {LastName}  ");
            }
        }
    
}
