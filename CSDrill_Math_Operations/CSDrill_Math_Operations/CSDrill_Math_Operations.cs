
using System;

namespace Console_App

{

    class Program

    {
        static void Main()

        {

            //TAKES AN INPUT, MULTIPLIES BY 50 AND PRINTS RESULT

            Console.WriteLine("pick a number");

            string numb = Console.ReadLine();
            int number = Convert.ToInt32(numb);
            int total = number * 50;

            Console.WriteLine(total);
            Console.ReadLine();



            //tAKES AN INPUT, ADDS 25 AND PRINTS RESULT


            Console.WriteLine("pick a number!");

            string numb2 = Console.ReadLine();
            int number2 = Convert.ToInt32(numb2);
            int total2 = number2 + 25;

            Console.WriteLine(total);
            Console.ReadLine();


            //TAKES AN INPUT, DIVIDES BY 12.5 AND PRINTS RESULT



            Console.WriteLine("Pick a number!");
            string numb3 = Console.ReadLine();
            Double number3 = Convert.ToDouble(numb3);
            Double total3 = number3 / 12.5;
            Console.WriteLine(total3);
            Console.ReadLine();


            //TAKES AN INPUT, CHECKS IF GREATER THAN 50 AND PRINTS TRUE/FALSE


            Console.WriteLine("Pick a number!");
            string numb4 = Console.ReadLine();
            int number4 = Convert.ToInt32(numb4);

            bool greaterthanfifty = number4 > 50;
            Console.Write(greaterthanfifty.ToString());
            Console.Read();


            //TAKES AN INPUT, DIVIDES BY 7 AND PRINTS REMAINDER

            Console.WriteLine("Pick a number!");
            string numb5 = Console.ReadLine();
            int number5 = Convert.ToInt32(numb5);
            Console.WriteLine(number5 % 7);
            Console.ReadLine();

        }


    }


}