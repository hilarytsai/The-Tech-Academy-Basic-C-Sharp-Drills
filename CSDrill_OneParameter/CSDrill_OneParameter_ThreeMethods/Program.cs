using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace threemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator operatorObject = new Operator();
            Console.WriteLine("This will add 10 to an input, subtract 5, and divide by 1. Enter input:");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var result = operatorObject.Add(userValue);
            result = operatorObject.Subtract(result);
            result = operatorObject.Divide(result);

            Console.WriteLine("result: " + result);
            Console.ReadLine();
        }
    }
}
