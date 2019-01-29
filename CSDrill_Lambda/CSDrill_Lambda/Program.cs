using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrill_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            {
                Employees.Add(new Employee() { firstname = "Joe", lastname = "Brown", ID = 343 });
                Employees.Add(new Employee() { firstname = "James", lastname = "Bond", ID = 37 });
                Employees.Add(new Employee() { firstname = "Freddie", lastname = "Mercury", ID = 693 });
                Employees.Add(new Employee() { firstname = "John", lastname = "Smith", ID = 674 });
                Employees.Add(new Employee() { firstname = "Joe", lastname = "Johnson", ID = 8 });
                Employees.Add(new Employee() { firstname = "Kitty", lastname = "Bryant", ID = 9 });
                Employees.Add(new Employee() { firstname = "Roger", lastname = "Taylor", ID = 678 });
                Employees.Add(new Employee() { firstname = "John", lastname = "Deacon", ID = 936 });
                Employees.Add(new Employee() { firstname = "Brian", lastname = "May", ID = 334 });
                Employees.Add(new Employee() { firstname = "Keith", lastname = "Richards", ID = 657 });

                Console.WriteLine("Hit any key to see a list of employees with the first name Joe.");
                Console.ReadLine();
                foreach (Employee employee1 in Employees)
                {
                    if (employee1.firstname == "Joe")
                    {
                        Console.WriteLine(employee1.firstname + " " + employee1.lastname);
                    }
                }

                Console.WriteLine("Hit any key to see the same with a lambda function.");
                Console.ReadLine();


                List<Employee> newList = Employees.Where(x => x.firstname == "Joe").ToList();

                foreach (Employee employee2 in newList)
                {
                    Console.WriteLine(employee2.firstname + " " + employee2.lastname);
                }
                Console.WriteLine("Hit enter to see a list of employees whose ID is greater than 5.");
                Console.ReadLine();

          

                List<Employee> EmployeeIDlist = Employees.Where(x => x.ID > 5).ToList();

                foreach (Employee Employee3 in EmployeeIDlist)
                {
                    Console.WriteLine(Employee3.firstname + " " + Employee3.lastname);
                }
                Console.ReadLine();           
            }
        }
    }
}
            
        
    
