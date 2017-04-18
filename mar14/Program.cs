using System;

namespace mar14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var player1 = new Player();
            var player2 = new Player();
    

            // æøå
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            int boardSize = 9;
            int shipSize =3;
            int maxCoordinate = boardSize - shipSize + 1;

            bool isFirstPlayer = true;

            Console.WriteLine("\nSpiller 1 indtast dit navn \n");
            player1.name = Console.ReadLine();
            
            Console.WriteLine("\nSpiller 2 indtast dit navn \n");
            player2.name = Console.ReadLine();


            for(int i=0; i<2; i++)
            {
                if(isFirstPlayer == true)
                {
                    Console.WriteLine("\n{0}'s tur! ", player1.name);
                }
                else
                {
                    Console.WriteLine("\n{0}'s tur! ", player2.name);
                }

                Console.WriteLine("\nSkla skibet ligge Vandret (V) eler Lodret (L)?");
                string direction = Console.ReadLine();
                bool isHorizontal = direction.Equals("V", StringComparison.OrdinalIgnoreCase);
            
            
                // Skibets placering
                int shipX = GetNumber(1,  isHorizontal ? maxCoordinate : boardSize, "\nHvor skal skibet ligge (x-kordinat)?") -1;

                int shipY = GetNumber(1, isHorizontal ? boardSize : maxCoordinate, "\nHvor skal skibet ligge (y-kordinat)?") -1;

                if(isFirstPlayer == true)
                {
                player1.PlaceShip(isHorizontal, shipX, shipY);
                }
                else
                {
                    player2.PlaceShip(isHorizontal, shipX, shipY);
                }
                isFirstPlayer = false;
            }


            isFirstPlayer = true;

            bool isHit = false;
            bool isSunk = false;
            while(!isSunk)
            {
                Player player;
                if(isFirstPlayer == true)
                {
                    player = player1;
                    isFirstPlayer = false;
                    Console.WriteLine("{0}'s tur! ", player1.name);
                }
                else
                {
                    player = player2;
                    isFirstPlayer = true;
                    Console.WriteLine("{0}'s tur! ", player2.name);
                }

                int ShootX = GetNumber(1, boardSize, "\nHvor vil du skyde hen (x-koordinat)") -1;

                int ShootY = GetNumber(1, boardSize, "\nHvor vil du skyde hen (y-koordinat)") -1;

                isHit = player.Shoot(ShootX,ShootY);
                isSunk = player.HasLost();


                Console.Clear();

                string header = "    ";
                string line = "   ";
                for(int z = 0; z < boardSize; z++)
                {
                    line = line + "----";
                    header += $"{z+1}   ";
                }

                Console.WriteLine(header);
                for(int y = 0; y < boardSize; y++)
                {
                    Console.WriteLine(line);
                    Console.Write(y + 1);

                    for(int x = 0; x < boardSize; x++)
                    {
                        Console.Write(" | ");
                      Console.Write(player.shots[x][y]);
                    }
                    Console.WriteLine(" | ");
                }
                Console.WriteLine(line);

                string hitText = isHit
                    ? "Du ramte!!!"
                    : "Du missede!!!";

                Console.WriteLine();
                Console.WriteLine(hitText);
                Console.WriteLine();
            }
        }
        public static int GetNumber(int min, int max, string message)
        {
            Console.WriteLine("{0} ({1}-{2})", message, min, max);
            int number = 0;

            bool isAccepted = false;
            while(isAccepted == false)
            {
                string input = Console.ReadLine();
                isAccepted = int.TryParse(input, out number) && 
                number >= min && 
                number <= max;

                if(isAccepted == false)
                {
                    Console.WriteLine("Ugyldigt tegn - prøv igen");
                }
            }
            return number;
        }
        
        public static bool GetIsHorizontal()
        {
            Console.WriteLine("Vandret eller lodret?");
            while(true)
            {
                string input = Console.ReadLine();
                if(input.StartsWith("V", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                Console.WriteLine("Ugyldigt tegn");
            }
        }
    }
}
