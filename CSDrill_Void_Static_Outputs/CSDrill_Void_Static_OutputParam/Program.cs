using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace voidmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            operateobject operate1 = new operateobject();
            Console.WriteLine("Pick a number.  This is a void method that outputs an integer.");
            int userValue = Convert.ToInt32(Console.ReadLine());



            operate1.operation(userValue);

            Console.WriteLine("Pick a number. This is an overloaded method of the same name, operate1.");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a number to multiply by");
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            operate1.operation(userinput, userinput2);


            Console.WriteLine("Once again, pick a number.  This will result in 2 output parameters.");
            int userValue2 = Convert.ToInt32(Console.ReadLine());

            operate1.output(userValue2, out int sum, out int subtracted);


            Console.WriteLine("Enter your name. This is a static class that concatenates string values.");
            string name = Console.ReadLine();
            staticclass.concatenate(name);
            Console.ReadLine();


        }
    }
}