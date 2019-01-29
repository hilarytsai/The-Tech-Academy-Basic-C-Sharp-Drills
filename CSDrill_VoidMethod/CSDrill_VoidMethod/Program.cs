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
            operateanddisplay voidmethod = new operateanddisplay();
            Console.WriteLine("Pick a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number");
            int userValue2 = Convert.ToInt32(Console.ReadLine());

            voidmethod.operate(data: userValue, data2: userValue2);




            Console.ReadLine();
        }
    }
}