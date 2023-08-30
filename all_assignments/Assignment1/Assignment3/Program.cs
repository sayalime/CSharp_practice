using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //3. Write a C# function named FindAverage that takes a List of integers as a parameter and returns the average
    //of the numbers in the list. Use this function to find the average of the "numberList" from Question 1.
    internal class Program
    {
        int sum=0; 
        public void FindAverage(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
            int average = sum / list.Count;
            Console.WriteLine(average);
        }
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 10,20,30,40,50};
            Program p = new Program();
            p.FindAverage(numberList);
            Console.ReadKey();
        }
    }
}
