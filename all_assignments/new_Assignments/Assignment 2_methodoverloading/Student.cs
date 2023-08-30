using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_methodoverloading
{
    internal class Student
    {
        public int Id;
        public string FirstName; 
        public string LastName;
        public int age;
        public void put_details(int Id, string FirstName, string LastName)
        {
            this.Id = Id;   
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void put_details(int age)
        {
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine($"Student id : {this.Id}");
            Console.WriteLine($"Student First Name : {this.FirstName} ");
            Console.WriteLine($"Student Last Name : {this.LastName}");
            Console.WriteLine($"Student Age : {this.age} ");
        }
    }
}
