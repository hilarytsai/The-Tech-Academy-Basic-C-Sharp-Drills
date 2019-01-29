
using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            int[] intArray = { 56, 45, 76, 234, 755, 99, 34, 22, 655, 1, 5 };
            Console.WriteLine("Choose an index between 0 and 10 to get a random number. If you get 1, you win!");
            int numindex = Convert.ToInt32(Console.ReadLine());
            bool ten = numindex <= 10;

            do
            {
                switch (numindex)
                {
                    case 11:
                        Console.WriteLine("\r\n" + " Index does not exist! Choose an index between 0 and 10.");
                        Console.WriteLine("Choose an index between 0 and 10.");
                        numindex = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 0:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 1:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 2:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 3:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 4:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 5:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 6:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 7:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 8:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    case 9:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "! you win!");
                        ten = true;
                        break;

                    case 10:
                        Console.WriteLine("\r\n" + "You chose " + intArray[numindex] + "!");
                        ten = true;
                        break;

                    default:
                        Console.WriteLine("\r\n" + "Index does not exist! Choose an index between 0 and 10.");
                        Console.WriteLine("Choose an index between 0 and 10.");
                        numindex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            while (!ten);


            string[] stringArray = { "orangutan", "zebra", "elephant", "lion", "tiger", "Trex", "cougar", "panther", "giraffe", "bear", "dolphin" };
            Console.WriteLine("\nChoose an index between 0 and 10 to see a random zoo animal! (if you get Trex, you lose!)");

            int index = Convert.ToInt32(Console.ReadLine());
            bool ten2 = index <= 10;

            do

            {
                switch (index)
                {

                    case 11:
                        Console.WriteLine("\r\n" + " Index does not exist! Choose an index between 0 and 10.");
                        Console.WriteLine("Choose an index between 0 and 10.");
                        index = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 0:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 1:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 2:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 3:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 4:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 5:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!  Ouch! You lose!");
                        ten2 = true;
                        break;

                    case 6:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 7:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 8:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 9:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    case 10:
                        Console.WriteLine("\r\n" + "You chose " + stringArray[index] + "!");
                        ten2 = true;
                        break;

                    default:
                        Console.WriteLine("\r\n" + "Index does not exist! Choose an index between 0 and 10.");
                        Console.WriteLine("Choose an index between 0 and 10.");
                        index = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!ten2);

            List<string> stringList = new List<string>();

            stringList.Add("grapes");
            stringList.Add("bananas");
            stringList.Add("oranges");
            stringList.Add("apples");
            stringList.Add("guavas");
            stringList.Add("raspberries");
            stringList.Add("pears");
            stringList.Add("strawberries");
            stringList.Add("cherrybomb");
            stringList.Add("passionfruit");
            stringList.Add("watermelon");

            Console.WriteLine("\nChoose an index between 0 and 10 to pick a random fruit. If you get the cherrybomb, you lose!");

            int listindex = Convert.ToInt32(Console.ReadLine());
            bool ten3 = listindex <= 10;
            do
            {
                switch (listindex)
                {
                    case 11:
                        Console.WriteLine("\r\n" + " Index does not exist! Choose an index between 0 and 10.");
                        listindex = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 0:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 1:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 2:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 3:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 4:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 5:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 6:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 7:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 8:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "! BOOM! You lose!");
                        ten3 = true;
                        break;
                  
                    case 9:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    case 10:
                        Console.WriteLine("\r\n" + "You chose " + stringList[listindex] + "!");
                        ten3 = true;
                        break;

                    default:
                        Console.WriteLine("\r\n" + "Index does not exist! Choose an index between 0 and 10.");
                        listindex = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }


            while (!ten3);
            Console.ReadLine();

        }
    }
}
