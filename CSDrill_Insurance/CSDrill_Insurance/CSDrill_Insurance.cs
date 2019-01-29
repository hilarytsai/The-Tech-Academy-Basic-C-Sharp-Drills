using System;

namespace Console_App

{
    class Program

    {
        static void Main()

        {

            Console.WriteLine("Please answer the following questions to determine your car insurance eligibility:");


            Console.WriteLine("What is your age?");
            String Age = Console.ReadLine();


            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            String DUI = Console.ReadLine();


            Console.WriteLine("How many speeding tickets do you have?");
            String Tickets = Console.ReadLine();

            int Age2 = Convert.ToInt32(Age);
            bool hadDUI = Convert.ToBoolean(DUI);

            int Tickets2 = Convert.ToInt32(Tickets);
            bool Qualified = (Age2 > 15 && hadDUI == false && Tickets2 <= 3);


            Console.WriteLine("Qualification status: ");
            Console.Write(Qualified.ToString());
            Console.ReadLine();

        }

    }

}