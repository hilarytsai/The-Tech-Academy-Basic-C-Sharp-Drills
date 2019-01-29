
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class program
    {
        static void Main (string[] args)
        {
            Employee<string> example = new Employee<string>();
            example.Things = new List<string>() { "money", "computer", "car", "schedule", "desk" };


            Employee<int> example2 = new Employee<int>();
            example2.Things = new List<int>() { 33, 10, 3, 534, 5 };

            foreach (string item in example.Things)

            {
                Console.WriteLine(item);
            }

            foreach (int item in example2.Things)
            {
                Console.WriteLine(item);
              
            }
                Console.ReadLine();
        }
    }
}


