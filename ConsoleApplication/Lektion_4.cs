using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Lektion_4
    {
        public static void Run()
        {
            var calculator = new Calculator();
            //calculator.Add(2);
            //calculator.Add(5);
            //calculator.Multiply(2);
            //calculator.Divide(3);
            //calculator.Minus(4);

            string operation = "+";
            do
            {
                Console.WriteLine("indtast et tal: ");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);



                if (operation == "+")
                {
                    calculator.Add(number);
                }
                else if(operation == "-")
                {
                    calculator.Minus(number);
                }
                else if(operation == "*")
                {
                    calculator.Multiply(number);
                }
                else if(operation == "/")
                {
                    calculator.Divide(number);
                }
                else if(operation == "=")
                {
                }

                Console.WriteLine("indtast +, -, *, /, =");
                operation = Console.ReadLine();
                if(operation != "+" && operation != "-" && operation != "/" && operation != "*" && operation != "=" )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fejl. Ugyldig operation \nPrøv igen");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while(operation != "=");



            int resultat = calculator.Resultat();

            Console.Write("Resultat = ");
            Console.WriteLine(resultat);
        }  
    }
}
