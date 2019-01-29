using System;
namespace ConsoleApp7

{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate.");

            string rate = Console.ReadLine();

            Console.WriteLine("Enter hours worked per week.");

            string hours = Console.ReadLine();
            double rateperson1 = Convert.ToDouble(rate);
            double hoursperson1 = Convert.ToDouble(hours);
            double salary = rateperson1 * hoursperson1 * 52;


            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate.");

            string rate2 = Console.ReadLine();

            Console.WriteLine("Enter hours worked per week.");

            string hours2 = Console.ReadLine();
            double rateperson2 = Convert.ToDouble(rate2);

            double hoursperson2 = Convert.ToDouble(hours2);
            double salary2 = rateperson2 * hoursperson2 * 52;


            bool person1makesmore = salary > salary2;

            Console.WriteLine("Annual salary of Person 1: " + salary);
            Console.WriteLine("Annual salary of Person 2: " + salary2);
            Console.Write("Does Person 1 make more money than Person 2? ");
            Console.Write(person1makesmore.ToString());

            Console.ReadLine();

        }

    }

}