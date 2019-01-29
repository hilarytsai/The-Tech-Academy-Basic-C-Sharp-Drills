using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrill_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Number = new Number();
            Number.Amount = 44.5m;
            Console.WriteLine("Number Amount= "+Number.Amount);
            Console.ReadLine();
        }
    }
}
