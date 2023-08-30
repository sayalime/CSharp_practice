using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_app
{
    internal class Program
    {
        //C# Assignment. Write A Console App In C# That Calculates A Total Bill At For Two Meals At A Restaurant
        static void Main(string[] args)
        {
            Console.Write("Enter meal1 cost: ");
            int meal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the quantity for Meal 1: ");
            int meal1Q = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter meal2 cost: ");
            int meal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the quantity for Meal 2: ");
            int meal2Q = Convert.ToInt32(Console.ReadLine());

            int total = (meal1 * meal1Q) + (meal2 * meal2Q);
            Console.WriteLine("\n*** Receipt ***");
            Console.WriteLine($"Meal 1 - Cost: ${meal1}, Quantity: {meal1Q}, Subtotal: ${meal1 * meal1Q}");
            Console.WriteLine($"Meal 2 - Cost: ${meal2}, Quantity: {meal2Q}, Subtotal: ${meal2 * meal2Q}");
            Console.WriteLine($"Total Bill: ${total}");

            Console.ReadKey();
        }
    }
}
