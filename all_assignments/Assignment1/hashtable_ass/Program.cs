using System;
using System.Collections;

namespace hashtable_ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("Name", "Sayali");
            hash.Add("msg", "Hi");
            hash.Add("fruit", "Mango");
            hash.Add("1", "3");
            Console.WriteLine("Original hashtable");
            hash.display();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Get method called : "+hash.Get("msg"));
            Console.WriteLine("Contains method called : "+hash.Contains("Name"));
            Console.WriteLine("Remove method called : "+hash.Remove("1"));
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Updated hashtable");
            hash.display();
            Console.ReadKey();
        }
    }
}
