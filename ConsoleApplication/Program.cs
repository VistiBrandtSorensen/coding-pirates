using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("indtast x:");
            string x = Console.ReadLine();
            int talX;
            if (!int.TryParse(x, out talX)
            {
                Console.WriteLine("pröv igen med et tal");
                y = Console.ReadLine();
                if (!int.TryParse(x, out talX)
                {
                    Console.WriteLine("fejl igen");
                    return;
                }
            }


            Console.WriteLine("indtast y:");
            string y = Console.ReadLine();
            int talY;
           if (!int.TryParse(y, out talY)
           {
                Console.WriteLine("pröv igen med et tal");
                y = Console.ReadLine();
                if (!int.TryParse(y, out talY)
                {
                    Console.WriteLine("fejl igen");
                    return;
                }
            }


            Console.WriteLine("x + y er");
            Console.WriteLine(talX + talY);
        }
    }
}
