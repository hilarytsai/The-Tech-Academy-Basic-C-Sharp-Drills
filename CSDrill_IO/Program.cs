using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSDrill_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number.");
            string number = Console.ReadLine();
            string text = number;
            File.WriteAllText(@"C:\iotext\number.txt", text);
            
            //using (StreamWriter file = new StreamWriter("C:\\iotext\\number.txt", true))
            //{
               // file.WriteLine(text);                         
            //}

            string readText = File.ReadAllText("C:\\iotext\\number.txt");
            Console.WriteLine("\nThe number logged to the text file is: "+readText);
            Console.Read();

        }
    }
}

