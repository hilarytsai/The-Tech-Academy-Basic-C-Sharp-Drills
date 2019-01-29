
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Kitty";
            example.LastName = "Katz";
            example.ID = 24923;

            Employee example2 = new Employee();
            example2.FirstName = "John";
            example2.LastName = "Deacon";
            example2.ID = 39292;

            Employee example3 = new Employee();
            example3.FirstName = "Roger";
            example3.LastName = "Taylor";
            example3.ID = 49597;


            List<Employee> EmployeeList = new List<Employee>() {example, example3, example2};
            List<Employee> EmployeeList2 = new List<Employee>() { example, example3, example2 };

            foreach (Employee employee1 in EmployeeList)       
            {
                foreach (Employee employee2 in EmployeeList2)
                {

                    bool compare = employee1.ID == employee2.ID;
                    if (compare)
                    {                
                        Console.WriteLine(employee1.FirstName +" "+ employee1.LastName+" And " + employee2.FirstName +" "+employee2.LastName+ " have the same ID.");                       
                    }
                    else
                    {
                    continue;
                        }               
                }
            }

            Console.ReadLine();
        }
    }
}