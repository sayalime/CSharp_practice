using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace list_pr
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //insertAll();
            getall();
            //Delete();

            Console.ReadKey();
        }
        public static void update()
        {
            SqlConnection s = Program.connection();
            s.Open();
            string q = "";
        }
        private static void insertAll()
        {
            SqlConnection s = Program.connection();
            s.Open();
            Console.WriteLine("Enter name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Standard");
            string Standard = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            string i = $"insert into Student_table(Name,Standard,Age) values('{Name}','{Standard}','{Age}')";
            Console.WriteLine("Record inserted successfully");
            SqlCommand res = new SqlCommand(i, s);
            res.ExecuteNonQuery();
        }

        static void getall()
        {
            SqlConnection s = Program.connection();
            s.Open();
            string q = "select * from Student_table";
            SqlCommand res = new SqlCommand(q, s);

            SqlDataReader r = res.ExecuteReader();
            while (r.Read())
            {

                int id = Convert.ToInt32(r["Id"]);
                string name = r["Name"].ToString();
                int standard = Convert.ToInt32(r["Standard"]);
                int age = Convert.ToInt32(r["Age"]);

                Console.WriteLine($" Id : {id}\n Name: {name}\n Standard: {standard}\n Age: {age}");
            }
            s.Close();
        }
        static void Delete()
        {
            SqlConnection s = Program.connection();
            s.Open();
            Console.WriteLine("Enter id of the record you want to delete");
            int ch_id = Convert.ToInt32(Console.ReadLine());
            string q = $"DELETE FROM Student_table WHERE id = {ch_id}";
            
            Console.WriteLine("Record Deleted Successfully");
            SqlCommand res = new SqlCommand(q, s);
            res.ExecuteNonQuery();

            s.Close();
        }


        /*static SqlConnection connection()
        {
            string con = "Data Source=DESKTOP-C39UGFH\\SQLEXPRESS;Database=console_app_db;Integrated Security=sspi;";
            SqlConnection s = new SqlConnection(con);
            return s;
        }*/
        static SqlConnection connection()
        {
            string con = "Data Source=DESKTOP-LFB8II7\\SQLEXPRESS;Database=Student_db;Integrated Security=sspi;";
            SqlConnection s = new SqlConnection(con);
            return s;
        }
    }
}
