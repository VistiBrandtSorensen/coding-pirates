namespace BattleShip
{
    class Game
    {
        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
        }
        public Player Player1;
        public Player Player2;
        public int Turn;
        public bool Shoot (int X,int Y)
        {
            if(Player1.Board.Ship.X == X && Player1.Board.Ship.Y == Y)
            {
                return true;
            }
            return false;
        }
    }
}