using System;

namespace Restaurant_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meal1 = 0, meal1Q = 0, meal2 = 0, meal2Q = 0;

            while (true)
            {
                Console.WriteLine("Restaurant Billing System\n1. Add Meal\n2. View Items\n3. Calculate Total Bill\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter meal1 cost: ");
                        meal1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the quantity for Meal 1: ");
                        meal1Q = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter meal2 cost: ");
                        meal2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the quantity for Meal 2: ");
                        meal2Q = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\n*** Current Items ***");
                        Console.WriteLine($"Meal 1 - Cost: {meal1}, Quantity: {meal1Q}");
                        Console.WriteLine($"Meal 2 - Cost: {meal2}, Quantity: {meal2Q}");
                        break;
                    case 3:
                        int total = (meal1 * meal1Q) + (meal2 * meal2Q);
                        Console.WriteLine("\n*** Receipt ***");
                        Console.WriteLine($"Meal 1 - Cost: {meal1}, Quantity: {meal1Q}, Subtotal: {meal1 * meal1Q}");
                        Console.WriteLine($"Meal 2 - Cost: {meal2}, Quantity: {meal2Q}, Subtotal: {meal2 * meal2Q}");
                        Console.WriteLine($"Total Bill: {total}");
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
