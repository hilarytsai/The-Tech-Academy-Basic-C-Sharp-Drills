using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    class Employee : Person
    {
        public int ID { get; set; }

        public override void SayName()
        {
            {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            }


        }

    }    
}