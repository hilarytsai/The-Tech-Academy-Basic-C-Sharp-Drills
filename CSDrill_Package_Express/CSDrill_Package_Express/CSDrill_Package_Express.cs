
using System;
namespace Console_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
            Console.WriteLine("Enter package weight in lbs:");

            String Weight = Console.ReadLine();
            double Weight2 = Convert.ToDouble(Weight);

            if (Weight2 > 50)

            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express! Have a good day.");
                Console.ReadLine();

            }
            else

            {
                Console.WriteLine("Enter package width.");

                string Width = Console.ReadLine();

                Console.WriteLine("Enter package height");

                string Height = Console.ReadLine();

                Console.WriteLine("Enter package length");

                string Length = Console.ReadLine();

                double Width2 = Convert.ToDouble(Width);

                double Height2 = Convert.ToDouble(Height);

                double Length2 = Convert.ToDouble(Width);

                double sum = Width2 + Height2 + Length2;


                if (sum > 50)

                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express!");

                    Console.ReadLine();

                }

                else

                {
                    double Sum2 = sum * Weight2 / 100;

                    Console.WriteLine("Your total shipping cost will be:");

                    Console.WriteLine("$" + Sum2);

                    Console.WriteLine("Thank you for choosing Package Express!");

                    Console.ReadLine();

                }

            }

        }

    }

}