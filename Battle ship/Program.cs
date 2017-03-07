using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleShip;

namespace Battle_ship
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            Console.Write("Skriv dit navn player 1: ");
            game.Player1.Name = Console.ReadLine();

            Console.Write("Skriv dit navn player 2: ");
            game.Player2.Name = Console.ReadLine();

            Console.WriteLine("velkommen {0} og {1}", game.Player1.Name, game.Player2.Name);

            // player 1, 2 kordinater
            Console.WriteLine("skriv kordinat 1: ");
            game.Player1.Board.Ship.X = int.Parse(Console.ReadLine());

            Console.WriteLine("skriv kordinat 2: ");
            game.Player1.Board.Ship.Y = int.Parse(Console.ReadLine());


            Console.WriteLine("skriv kordinat 1: ");
            game.Player2.Board.Ship.X = int.Parse(Console.ReadLine());

            Console.WriteLine("skriv kordinat 2: ");
            game.Player2.Board.Ship.Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv retning Lodret eller Vandret: ");

            string direction = Console.ReadLine();

            if(direction == "Lodret")
            {
                game.Player1.Board.Ship.Direction = Direction.Vertical;
            }
            else
            {
                game.Player1.Board.Ship.Direction = Direction.Horisontal;
            }

            Console.WriteLine("Skriv retning Lodret eller Vandret: ");
            direction = Console.ReadLine();

            if(direction == "Lodret")
            {
                game.Player2.Board.Ship.Direction = Direction.Vertical;
            }
            else
            {
                game.Player2.Board.Ship.Direction = Direction.Horisontal;
            }

            Console.WriteLine("skyd kordinat 1 :");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("skyd kordinat 2 :");
            int y = int.Parse(Console.ReadLine());


            bool isHit = game.Shoot(x, y);

            if(isHit == true)
            {
                Console.WriteLine("du ramte");
            }
            else
            {
                Console.WriteLine("du ramte dsv ikke");
            }
        }
    }
}
