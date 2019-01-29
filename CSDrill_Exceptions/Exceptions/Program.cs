using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        //dividebyzero
        {
            try//system.formatexception
            {
                Console.WriteLine("Pick a number");
                int picked = Convert.ToInt32(Console.ReadLine());
                List<int> nums = new List<int>() { 100, 90, 80, 60, 40, 20 };
                foreach (int num in nums)
                {
                    {
                        int num2 = num / picked;
                        Console.WriteLine(num + " divided by " + picked + " equals " + num2);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That is not a valid number!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Zero is not valid.");
            }
            Console.ReadLine();
        }
    }
}
