using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrill_ExceptionHandling_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            while (!valid)

                try
                {
                    Console.WriteLine("Please enter your age.");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age<=0)
                    {
                        throw new OverflowException();
                    }

                    DateTime year = DateTime.Now.AddYears(-age);
                    Console.WriteLine("\nYour birth year: "+year);
                    Console.ReadLine();
                    return;
                }

                catch (OverflowException)
                {
                    Console.WriteLine("\nYour age cannot be zero or negative!");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInput invalid!");
                }
            
            Console.ReadLine();               
        }
    }
}
//I couldn't get it to display only the year because DateTime.Now.Year cannot be paired with 
//AddYears.  How can I make it display just the birth year?