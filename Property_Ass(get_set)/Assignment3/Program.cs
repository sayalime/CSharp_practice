using System;

namespace Assignment3
{
    internal class Program
    {
        public int ProductId = 1;
        public readonly int productId;
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Program(string productName, int price, int quantity)
        {
            productId += ProductId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public void SellQuantity(int sold)
        {
            if (Quantity <= 0)
            {
                Console.WriteLine("Invalid Quantity");
            }
            else if (Quantity < sold)
            {
                Console.WriteLine("Not Enough Quantity to Sell");
            }
            else
            {
                Quantity -= sold;
                Console.WriteLine($"Sold quantity: {sold}");
            }
        }

        public void AddQuantity(int added)
        {
            if (added <= 0)
            {
                Console.WriteLine("Invalid quantity to add");
            }
            else
            {
                Quantity += added;
                Console.WriteLine($"Restocked quantity: {added}");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Product Id: {ProductId} \nProduct Name: {ProductName} \nProduct Price: {Price} \nProduct Quantity: {Quantity}");
        }

        static void Main(string[] args)
        {
            Program p = new Program("phone", 30000, 10);
            p.Display();
            Console.WriteLine("After selling a product, updated quantity:");
            p.SellQuantity(2);
            p.Display();
            Console.WriteLine("After adding product quantity, restocked quantity:");
            p.AddQuantity(3);
            p.Display();
            Console.ReadKey();
        }
    }
}
