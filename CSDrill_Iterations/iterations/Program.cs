
using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type your name");
        string name = Console.ReadLine();

        string[] animals = { "baboon", "tiger", "dog", "cat", "wolf" };
        for (int j = 0; j < animals.Length; j++)
        {
            Console.WriteLine(name + "'s favorite animal is " + animals[j]);
        }
        Console.WriteLine("\nHit enter to see an infinite loop that was then programmed to end (infinite loop will happen at the end.)");
        Console.ReadLine();



        for (int j = 0; j < 50; j++)

        {
            Console.WriteLine("This loop will end after 50 iterations.");
        }
        Console.WriteLine("END");
        Console.WriteLine("\nHit enter to see a < comparison.");
        Console.ReadLine();

        for (int j = 0; j < 100; j++)

        {
            Console.WriteLine("J is less than 100.");
        }
        Console.WriteLine("J is now equal to 100.");
        Console.WriteLine("\n Hit enter to see a <= comparison.");
        Console.ReadLine();

        for (int j = 0; j <= 100; j++)

        {
            Console.WriteLine("j is less than or equal to 100.");


        }
        Console.WriteLine("\nEnter your birth month (capitalize first letter)");



        //ASKS USER TO ENTER BIRTH MONTH AND DISPLAYS BIRTHSTONE.
        //IS THERE A BETTER WAY TO DO THIS THAN HAVING A LINE FOR EVERY MONTH? AND HOW CAN I INTEGRATE A LOOP TO 
        //GO BACK TO THE ARRAY ONCE A USER ENTERS AN INVALID MONTH?

        string birthmonth = Console.ReadLine();
        List<string> months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        foreach (string month in months)


        {
            if (month == "January" && birthmonth == "January")
            {
                Console.WriteLine(month + " Your birthstone is garnet.");

            }
            else if (month == "February" && birthmonth == "February")
            {
                Console.WriteLine("Your birthstone is Amethyst.");
            }
            else if (month == "March" && birthmonth == "March")
            {
                Console.WriteLine("Your birthstone is Aquamarine.");
            }
            else if (month == "April" && birthmonth == "April")
            {
                Console.WriteLine("Your birthstone is Crystal");
            }
            else if (month == "May" && birthmonth == "May")
            {
                Console.WriteLine("Your birthstone is Emerald.");
            }
            else if (month == "June" && birthmonth == "June")
            {
                Console.WriteLine("Your birthstone is Light Amethyst.");
            }
            else if (month == "July" && birthmonth == "July")
            {
                Console.WriteLine("Your birthstone is Ruby.");
            }
            else if (month == "August" && birthmonth == "August")

            {
                Console.WriteLine("Your birthstone is Peridot.");
            }
            else if (month == "September" && birthmonth == "September")
            {
                Console.WriteLine("Your birthstone is sapphire.");
            }
            else if (month == "October" && birthmonth == "October")
            {
                Console.WriteLine("Your birthstone is Rose.");
            }
            else if (month == "November" && birthmonth == "November")

            {
                Console.WriteLine("\nYour birthstone is Topaz.");
            }
            else if (month == "December" && birthmonth == "December")
            {
                Console.WriteLine("\nYour birthstone is Light Sapphire.");

            }

        }


        Console.WriteLine("\npick a day of the week to see the indices of that day (make sure to capitalize)");
        string chosen = Console.ReadLine();


        string[] daylist = new string[11];
        daylist[0] = "Monday";
        daylist[1] = "Thursday";
        daylist[2] = "Saturday";
        daylist[3] = "Monday";
        daylist[4] = "Sunday";
        daylist[5] = "Wednesday";
        daylist[6] = "Friday";
        daylist[7] = "Tuesday";
        daylist[8] = "Friday";
        daylist[9] = "Tuesday";
        daylist[10] = "Saturday";


        for (int j = 0; j < daylist.Length; j++)
        {
            {
                if (daylist[j].Contains(chosen))
                {

                    Console.WriteLine("\n" + chosen + " index: " + j);

                }
            }
        }


        //Here again, having trouble looping. I don't get how to implement a loop with iterations. Is there a better way besides
        //"switch/case" to do a loop for this situation?


        List<string> colors = new List<string>() { "red", "blue", "red", "yellow", "green", "purple", "green", "yellow" };
        List<string> repeated = new List<string>();
        Console.WriteLine("\nHit enter to see a list of colors and whether or not they appear more than once.");
        Console.ReadLine();
        foreach (string color in colors)
        {
            {
                if (repeated.Contains(color))
                {
                    Console.WriteLine(color + " appears");
                }
                else
                {
                    repeated.Add(color);
                    Console.WriteLine(color + " doesn't appear");
                }
            }
        }

        //INFINITE LOOP IS AT THE END, AND I DEMONSTRATED STOPPING THE LOOP EARLIER. HOW DO YOU MAKE IT SO USER 
        //INPUT STOPS THE LOOP?

        Console.WriteLine("\nHit enter to see an infinite loop");
        Console.ReadLine();

        for (int j = 1; j > 0; j++)

        {
            Console.WriteLine("This loop is infinite.");
        }
        Console.ReadLine();
    }
}