using System;
namespace Console_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is a rock song generator. Answer the following questions to create your song:");

            Console.WriteLine("\nWhat is your first name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nName a place that's fun.");
            string place = Console.ReadLine();

            Console.WriteLine("\nWhat did you want to be when you grew up?");
            string what = Console.ReadLine();

            Console.WriteLine("\nName something you find gross.");
            string gross = Console.ReadLine();

            Console.WriteLine("\nName a body part");
            string body = Console.ReadLine();

            Console.WriteLine("\nName a two-syllable noun that rhymes with that body part.");
            string noun = Console.ReadLine();

            Console.WriteLine("\nName something you'd like to kick.");
            string kick = Console.ReadLine();

            Console.WriteLine("\nName an aggressive verb.");
            string verb = Console.ReadLine();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("\r\n\r\n" + name + ", you're a boy, make a big noise");
            sb.Append("\nplaying in the " + place);
            sb.Append("\ngonna be a big " + what + " someday!");
            sb.Append("\nYou got " + gross + " on your " + body);
            sb.Append("\nYou big " + noun);
            sb.Append("\nkicking your " + kick + " all over the place.");

            string you = "you";
            string singit = "\n\n sing it!";
            string verb2 = "\r\n" + verb + " you!!!";



            verb2 = verb2.ToUpper();

            you = you.ToUpper();
            singit = singit.ToUpper();

            sb.Append(singit);

            sb.Append("\nWe");
            sb.Append("\n Will");
            sb.Append("\n  We");
            sb.Append("\n   Will");
            sb.Append(verb2);


            sb.Append("\r\n\r\nWe");
            sb.Append("\n Will");
            sb.Append("\n  We");
            sb.Append("\n   Will");
            sb.Append(verb2);

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}

