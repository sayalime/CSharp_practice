using System;
using System.Linq;

namespace Assignment4
{
    internal class Program
    {
        public static int CountSpaces(string inputString)
        {
            return inputString.Count(c => c == ' ');
        }

        public static void InString(string input)
        {
            int spaceCount = CountSpaces(input);
            Console.WriteLine("Number of spaces: " + spaceCount);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            InString(input);
        }
    }
}
