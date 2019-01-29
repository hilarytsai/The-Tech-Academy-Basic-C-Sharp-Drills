using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable NewEmployee = new Employee();

            ((Employee)NewEmployee).FirstName = "Kitty";
            ((Employee)NewEmployee).LastName = "Katz";

            NewEmployee.Quit();
            Console.ReadLine();
        }
    }
}

