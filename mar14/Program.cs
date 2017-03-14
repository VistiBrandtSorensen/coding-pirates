using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var board = new bool[][]
            {
                new bool[]{ false, false , false ,false },
                new bool[]{ false, false , false ,false },
                new bool[]{ false, false , false ,false },
                new bool[]{ false, false , false ,false }
            };

            var shots = new char[][]
            {
                new char[]{ ' ', ' ', ' ', ' '},
                new char[]{ ' ', ' ', ' ', ' '},
                new char[]{ ' ', ' ', ' ', ' '},
                new char[]{ ' ', ' ', ' ', ' '}
            };

            // Skibets placering
            board[3][0] = true;

            bool isHit = false;
            while(isHit == false)
            {
                Console.WriteLine("Hvor vil du skyde hen (x-koordinat)");
                int ShootX = int.Parse(Console.ReadLine());

                Console.WriteLine("Hvor vil du skyde hen (y-koordinat)");
                int ShootY = int.Parse(Console.ReadLine());

                isHit = board[ShootX][ShootY];
                if(isHit)
                {
                    shots[ShootX][ShootY] = 'X';
                    Console.WriteLine("Du ramte!!!");
                }
                else
                {
                    shots[ShootX][ShootY] = '*';
                    Console.WriteLine("Du missede!!!");
                }
                for(int x = 0; x < 4; x++)
                {
                    Console.WriteLine("----------");

                    for(int y = 0; y < 4; y++)
                    {
                        Console.Write("| ");
                      Console.Write(shots[x][y]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------");
            }
        }
    }
}
