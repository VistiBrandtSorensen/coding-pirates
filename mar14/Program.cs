using System;

namespace mar14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player();
            
    

            // æøå
            Console.OutputEncoding = System.Text.Encoding.UTF8;



            // Console.WriteLine("Hvor stor skal spillepladen være (4-9)");
            // int boardSize = int.Parse(Console.ReadLine());
            // while (boardSize < 4 || boardSize > 9)
            // {
            //     Console.WriteLine("Ugyldig størrelse, prøv igen");
            //     boardSize = int.Parse(Console.ReadLine());
            // }

            int boardSize = 9;

            // var board = new bool[boardSize][];
            // var shots = new char[boardSize] [];
            // for (int i = 0; i < boardSize; i++)
            // {
            //     board[i] = new bool[boardSize];
            //     shots[i] = new char[boardSize];
            //     for(int j = 0; j < boardSize; j++)
            //     {
            //         board[i][j] = false;
            //         shots[i][j] = ' ';
            //     }
            // }

            int shipSize =3;
            int maxCoordinate = boardSize - shipSize + 1;

            Console.WriteLine("Skla skibet ligge Vandret (V) eler Lodret (L)?");
            string direction = Console.ReadLine();
            bool isHorizontal = direction.Equals("V", StringComparison.OrdinalIgnoreCase);


            // Skibets placering
            Console.WriteLine("Hvor vil du ligge skibet (x-kordinat) 1-{0}", isHorizontal ? maxCoordinate : boardSize);
            int shipX = int.Parse(Console.ReadLine())- 1;

            Console.WriteLine("Hvor vil du ligge skibet (y-kordinat) 1-{0}", isHorizontal ? boardSize : maxCoordinate);
            int shipY = int.Parse(Console.ReadLine())- 1;

            player.PlaceShip(isHorizontal, shipX, shipY);

            // for (int i = 0; i < shipSize; i++)
            // {
            //     int x = isHorizontal 
            //     ? shipX + i 
            //     : shipX;
            //     int y = isHorizontal
            //     ? shipY
            //     : shipY + i;
            //     board[x][y] = true;
            // }

            bool isHit = false;
            bool isSunk = false;
            while(isSunk == false)
            {
                Console.WriteLine("Hvor vil du skyde hen (x-koordinat)");
                int ShootX = int.Parse(Console.ReadLine())- 1;

                Console.WriteLine("Hvor vil du skyde hen (y-koordinat)");
                int ShootY = int.Parse(Console.ReadLine())- 1;

                isHit = player.Shoot(ShootX,ShootY);
                isSunk = player.HasLost();

                // isHit = board[ShootX][shipY];
                // board[shipX][ShootY] = false;
                // isSunk = IsShipSunk(board);


                // string hitText;
                // if(isHit)
                // {
                //     shots[ShootX][ShootY] = 'X';
                //     hitText = "Du ramte!!";
                // }
                // else
                // {
                //     shots[ShootX][ShootY] = '*';
                //     hitText = "Du missede!!!";
                // }

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
    //     static bool IsShipSunk(bool[][] board)
    //     {
    //         bool isNotSunk = false;
    //         for (int x = 0; x < board.Length; x++)
    //         {
    //             var row = board[x];
    //             for(int y = 0; y < row.Length; y++)
    //             {
    //                 isNotSunk |= row[y];
    //             }
    //         }
    //         return isNotSunk == false;
    //     }
    }
}
