using System;
using System.Data.SqlClient;

namespace Sql_Ass1
{
    class Program1
    {
        public void Create_table()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=DESKTOP-C39UGFH\\SQLEXPRESS;Database=console_app_db;Integrated Security=sspi;");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
