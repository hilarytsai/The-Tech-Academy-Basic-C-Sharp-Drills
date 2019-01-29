using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSDrill_AdditionalFeatures
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will test you for cat hoarding behavior. How many cats do you own?");
          
            var OwnedCats = Convert.ToInt32(Console.ReadLine());
            CatCount Count = new CatCount(OwnedCats);

            Console.WriteLine("How many total cats do you desire?");
            var DesiredCats = Convert.ToInt32(Console.ReadLine());
        
            const string problem= "You have a cat problem! Call this number: 555-555-555.";
            var result = Count.Hoarder(OwnedCats, DesiredCats);

            Console.WriteLine("Hoarder status: " + result);

            if (result == true)
            {
                Console.Write(problem + " You can get better!");
            }
                         
            Console.Read();
        }

    }

}


//1. Create a const variable

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.