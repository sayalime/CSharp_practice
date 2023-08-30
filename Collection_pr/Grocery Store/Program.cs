using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;

namespace Grocery_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();  
            while (true)
            {
                Console.WriteLine("Enter Your Choice:\n1. Add\n2. Delete\n3. Display\n4. Exit");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        SqlConnection connection = CreateConnection();
                        connection.Open();

                        Console.WriteLine("Enter ID:");
                        string id;
                        arrayList.Add( id = Console.ReadLine());

                        Console.WriteLine("Enter Product:");
                        string product;
                        arrayList.Add( product = Console.ReadLine());

                        Console.WriteLine("Enter Quantity:");
                        string quantity;
                        arrayList.Add( quantity = Console.ReadLine());

                        Console.WriteLine("Enter Price:");
                        decimal price;
                        arrayList.Add(price = Convert.ToInt32(Console.ReadLine()));

                        string insertQuery = $"INSERT INTO grocery_store(Id, Product, Quantity, Price) VALUES('{id}', '{product}', '{quantity}', {price})";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.ExecuteNonQuery();

                        connection.Close();
                        break;
                    //case 2:
                    //    SqlConnection connection=CreateConnection();
                    //    connection.Open();

                    //    break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=DESKTOP-LFB8II7\\SQLEXPRESS;Database=student_db;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
