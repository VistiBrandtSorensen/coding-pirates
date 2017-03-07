namespace BattleShip
{
    class Board
    {
        public Board()
        {
            Ship = new Ship();
        }
        public int Length;
        public int Width;
        public Ship Ship;
    }
}