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
            Console.WriteLine("Pick another number--optional");
            string userinput = Console.ReadLine();
            int usernum;

            bool number = int.TryParse(userinput, out usernum);

            {
                if (number != true)
                {
                    int result = operatorObject.operate(userValue);
                    Console.WriteLine(userValue+"+4= "+result);
                    Console.ReadLine();
                }


                else
                {
                    int userValue2 = Convert.ToInt32(userinput);
                    int result = operatorObject.operate(userValue, userValue2);

                    Console.WriteLine(userValue+"+"+userValue2+"= "+result);
                    Console.ReadLine();
                }
            }
        }
    }
}