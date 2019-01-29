
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace interfaces
{
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit.");
        }
    }
}