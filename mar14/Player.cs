namespace mar14
{
    class Player
    {

        public string name;
        bool isFirstPlayerTurn = true;

         public bool[][] board;
         public char[][] shots;

         public Player()
         {
            int boardSize = 9;

            board = new bool[boardSize][];
            shots = new char[boardSize] [];
            for (int i = 0; i < boardSize; i++)
            {
                board[i] = new bool[boardSize];
                shots[i] = new char[boardSize];
                for(int j = 0; j < boardSize; j++)
                {
                    board[i][j] = false;
                    shots[i][j] = ' ';
                }
            }
         }


         public void PlaceShip(bool isHorizontal, int shipX,int shipY)
         {
            int shipSize = 3;

            for (int i = 0; i < shipSize; i++)
            {
                int x = isHorizontal 
                ? shipX + i 
                : shipX;
                int y = isHorizontal
                ? shipY
                : shipY + i;
                board[x][y] = true;
            }
         }

        public bool Shoot(int x,int y)
        {
            bool isHit = board[y][y];
            board[x][y] = false;

            if(isHit)
            {
                shots[x][y] = 'X';
            }
            else
            {
                 shots[x][y] = '*';
            }
            return isHit;
        }

        public bool HasLost()
        {
                bool isNotSunk = false;

                for (int x = 0; x < board.Length; x++)
                {
                    var row = board[x];
                    for(int y = 0; y < row.Length; y++)
                    {
                        isNotSunk |= row[y];
                    }
                }
            return isNotSunk == false;
        }
    }
}