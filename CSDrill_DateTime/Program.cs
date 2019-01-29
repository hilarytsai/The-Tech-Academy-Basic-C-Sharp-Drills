using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSDrill_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime.Now current = new DateTime();
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Type a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime timeInNumber = DateTime.Now.AddHours(number);
            Console.WriteLine("In "+number+" hour(s) it will be: "+timeInNumber);
            Console.Read();
<<<<<<< HEAD
    
=======

     
>>>>>>> 04aeb99eb2fcad078e6ff979384de28b5b23afb7
        }
    }
}
