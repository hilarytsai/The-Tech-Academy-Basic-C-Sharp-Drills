﻿using System;
namespace Console_App

{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");

            String course = Console.ReadLine();      
            Console.WriteLine("What page are you on?");
            string page = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string help = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }

    }

}
