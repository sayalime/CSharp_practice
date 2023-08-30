using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        private int stud_id;
        private string name;
        private int age;
        public string Location { get; set; }
        public int Stud_id
        {
            get
            {
                return stud_id;
            }
            set
            {
                stud_id = value;
            }
        }
        public string GetName
        {
            get
            {
                return name;
            } 
        }
        public void Name(String nam)
        {
            name = nam;
            
        }
        public int GetAge
        {
            get
            {
                return age;
            }
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        
    }
}
