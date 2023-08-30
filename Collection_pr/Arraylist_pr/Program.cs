using System;
using System.Collections;

namespace Arraylist_pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() { 20, "sayali", 30 };
            a.Add(1);
            a.Add("abc");
            a.Add(100);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Current Elements:");
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Menu:\n1. Add\n2. Count\n3. Reverse\n4. Sort\n5. Clear\n6. Display\n7. Exit");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Element you want:");
                        string newInput = Console.ReadLine();
                        a.Add(newInput);
                        Console.WriteLine("Element added successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Count : " + a.Count);
                        break;
                    case 3:
                        a.Reverse();
                        Console.WriteLine("List reversed.");
                        break;
                    case 4:
                        a.Sort();
                        Console.WriteLine("List sorted.");
                        break;
                    case 5:
                        a.Clear();
                        Console.WriteLine("List cleared.");
                        break;
                    case 6:
                        Console.WriteLine("Displaying elements:");
                        foreach (var item in a)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
