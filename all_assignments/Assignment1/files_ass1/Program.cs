using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files_ass1
{
    internal class Program
    {
        
        public void Read()
        { //Task 1: Reading from a File

            string path = @"C:\input.txt";
            if (File.Exists(path))
            {
                using (TextReader reader = File.OpenText(path))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
        public void Write()
        {//Task 2: Writing to a File

            string path = @"D:\new_file.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
                using (TextWriter writer = File.CreateText(path))
                {
                    writer.WriteLine("hey");
                    writer.WriteLine("Hello");
                    writer.WriteLine("What's Up");
                }
            Console.WriteLine("The write method has been called successfully here");
            
        }
        public void Copy()
        {
            string f1= @"D:\toDelete.txt";
            string f2 = @"D:\copiedd_file.txt";
            File.Copy(f1, f2);
            Console.WriteLine("file copied");
        }
        public void Delete()
        {
            string path = @"D:\copied_file.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
        }
        static void Main(string[] args)
        {
           Program p=new Program();
            // p.Read();
            //p.Write();
            //p.Copy();
            p.Delete();


            Console.ReadLine();
        }
    }
}
