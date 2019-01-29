
using System;
namespace Console_App
{
    class Program

    {
        static void Main()
        {
            Console.WriteLine("Choose any primary color");
            string color = Console.ReadLine();
            bool primary = color == "red" || color == "yellow" || color == "blue";

            do
            {

                switch (color)
                {

                    case "green":
                        Console.WriteLine("Green is not a primary color! Choose another color.");
                        color = Console.ReadLine();
                        break;


                    case "purple":
                        Console.WriteLine("Purple is not a primary color! Choose another color.");
                        color = Console.ReadLine();
                        break;


                    case "orange":
                        Console.WriteLine("Orange is not a primary color! Choose another color.");
                        color = Console.ReadLine();
                        break;


                    case "red":
                        Console.WriteLine("Good job! Red is a primary color!");
                        primary = true;
                        break;

                    case "yellow":
                        Console.WriteLine("Good job! Yellow is a primary color!");
                        primary = true;
                        break;


                    case "blue":
                        Console.WriteLine("Good job! Blue is primary color!");
                        primary = true;
                        break;

                    default:

                        Console.WriteLine("Sorry!" + " " + color + " " + "is not a primary color! Choose another color.");
                        color = Console.ReadLine();
                        break;
                }
            }

            while (!primary);
            Console.Read();

        }
    }
}