using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Lektion_3
    {
        public static void Run()
        {
            Console.WriteLine("indtast tal 1");
            string x = Console.ReadLine();
            float talX;

            Console.WriteLine("indtast tal 2");
            string y = Console.ReadLine();
            float talY;

            Console.WriteLine("Plus, minus, gange, divider, pi eller procent");
            string plus = Console.ReadLine();
            if (!float.TryParse(x, out talX))
            {
                // FEJL
            }
            if (!float.TryParse(y, out talY))
            {
                // FEJL
            }
            if (plus == "+" || plus == "plus")
            {
                Console.Write("x + y = ");
                Console.Write(talX + talY);
            }
            else if(plus == "-" || plus == "minus")
            {
                Console.Write("x - y = ");
                Console.Write(talX - talY);
            }
            else if(plus == "*" || plus == "gange")
            {
                Console.Write("x * y = ");
                Console.Write(talX - talY);
            }
            else if(plus == "/" || plus == "divider")
            {
                Console.Write("x / y = ");
                Console.WriteLine(talX / talY);
            }
            else if(plus == "π" || plus == "pi")
            {
                Console.Write("x * pi= ");
                Console.WriteLine(talX * 3.1415);
            }
            else if(plus == "%" || plus == "procent")
            {
                Console.Write("x % y = ");
                Console.WriteLine(talX % talY);
            }
        }
    }
}
