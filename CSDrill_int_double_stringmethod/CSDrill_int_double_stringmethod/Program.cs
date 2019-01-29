using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oneparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator operatorObject = new Operator();
            Console.WriteLine("Pick a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());


            int result = operatorObject.operate(userValue);

            Console.WriteLine(userValue + "*2 is " + result);

            Console.WriteLine("pick a decimal");
            double userValue2 = Convert.ToDouble(Console.ReadLine());

            int result2 = Convert.ToInt32(operatorObject.operate(userValue2));

            Console.WriteLine("2+" + userValue2 + " rounded to the nearest integer is " + result2);

            Console.WriteLine("Pick an integer");

            string userValue3 = Console.ReadLine();
            int usernum;

            bool isnumber = int.TryParse(userValue3, out usernum);

            {
                if (isnumber == false)
                {
                    Console.WriteLine(userValue3 + " is not an integer!");
                    Console.ReadLine();
                }

                else
                {


                    int result3 = operatorObject.operate(userValue3);

                    Console.WriteLine(userValue3 + " divided by 2 to the nearest integer is " + result3);
                    Console.ReadLine();
                }
            }
        }

    }
}