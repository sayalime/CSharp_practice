using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supershop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------
            const int maxProducts = 100; // Maximum number of products the shop can hold
            string[] productNames = new string[maxProducts];
            int[] productQuantities = new int[maxProducts];
            double[] productPrices = new double[maxProducts];
            int numProducts = 0;



            while (true)
            {
                Console.WriteLine("Super Shop Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");



                int choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        if (numProducts < maxProducts)
                        {
                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine();



                            Console.Write("Enter product quantity: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());



                            Console.Write("Enter product price: ");
                            double price = Convert.ToDouble(Console.ReadLine());



                            productNames[numProducts] = name;
                            productQuantities[numProducts] = quantity;
                            productPrices[numProducts] = price;



                            numProducts++;
                            Console.WriteLine("Product added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Shop capacity is full. Cannot add more products.");
                        }
                        break;



                    case 2:
                        if (numProducts > 0)
                        {
                            Console.WriteLine("Products in the shop:");
                            Console.WriteLine("Name\t\tQuantity\tPrice");
                            for (int i = 0; i < numProducts; i++)
                            {
                                Console.WriteLine($"{productNames[i]}\t\t{productQuantities[i]}\t\t{productPrices[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No products in the shop.");
                        }
                        break;



                    case 3:
                        Console.Write("Enter the product name to search: ");
                        string searchName = Console.ReadLine();
                        int foundIndex = -1;
                        for (int i = 0; i < numProducts; i++)
                        {
                            if (productNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                foundIndex = i;
                                break;
                            }
                        }
                        if (foundIndex != -1)
                        {
                            Console.WriteLine($"Product found: {productNames[foundIndex]}, Quantity: {productQuantities[foundIndex]}, Price: {productPrices[foundIndex]}");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;
                    case 4:
                        if (numProducts > 0)
                        {
                            int i;
                            double Bill = 0;
                            Console.WriteLine("*************Super shop**********************");
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("Name\t\tQuantity\tPrice");
                            Console.WriteLine("--------------------------------------------------------------");
                            for (i = 0; i < numProducts; i++)
                            {
                                Console.WriteLine($"{productNames[i]}\t\t{productQuantities[i]}\t\t{productPrices[i]}");
                                Bill = Bill + (productQuantities[i] * productPrices[i]);
                            }
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine($"Total PRoducts {i}  \t Total Bill  {Bill}");
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("No products in the shop.");
                        }
                        break;



                    case 5:
                        Console.WriteLine("Exiting the Super Shop Management System. Goodbye!");
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
