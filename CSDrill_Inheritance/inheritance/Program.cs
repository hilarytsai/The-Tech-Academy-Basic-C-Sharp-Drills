using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();
            example.FirstName = "Sample";
            example.LastName = "Student";

            example.SayName();

            Console.ReadLine();
            
        }
    }
}
