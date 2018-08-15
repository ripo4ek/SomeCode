namespace Player
{
    class Map
    {
        public char[,] Cells;

        public char GetCell(int x, int y)
        {
            return Cells[x, y];
        }

        public int Width
        {
            get
            {
                return Cells.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return Cells.GetLength(1);
            }
        }
    }
}