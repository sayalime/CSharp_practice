using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        //5. Write C# code to create a List of strings named "fruits". Add the following fruits to the list: "Apple",
        //"Banana", "Orange", "Mango", and "Grapes". Then, write code to check if the list contains the fruit "Banana".
        //If it does, remove "Banana" from the list; otherwise, add "Kiwi" to the list.
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.AddRange(new string[] { "Apple", "Banana", "Orange", "Mango", "Grapes" });
            if (fruits.Contains("Banana"))
            {
                fruits.Remove("Banana");
                Console.WriteLine("Removed");
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
            }
            else
            {
                fruits.Add("Kivi");
                Console.WriteLine("Added");
                foreach(string fruit in fruits)
                {
                       Console.Write(fruit);
                }
            }
            Console.ReadKey(); 
        }
    }
}
