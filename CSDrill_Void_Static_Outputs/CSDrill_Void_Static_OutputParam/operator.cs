
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace voidmethod

{
    public class operateobject
    {
        public void operation(int userValue)
        {
            int result = userValue / 2;

            Console.WriteLine(userValue + " divided by 2 is " + result);
        }


        public void operation(int userinput, int userinput2)

        {
            int result2 = userinput * userinput2;

            Console.WriteLine(userinput + " times " + userinput2 + " is " + result2);
        }


        public void output(int userValue2, out int sum, out int subtracted)
        {
            sum = userValue2 + 10;
            subtracted = userValue2 - 10;
            Console.WriteLine("The sum of " + userValue2 + " and 10 is " + sum + " and " + userValue2 + " minus 10 is " + subtracted);
        }

    }

}
