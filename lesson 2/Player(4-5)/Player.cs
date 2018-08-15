namespace Player
{
    class Player
    {
        public Health Health = new Health();
        public Map Map;
        public Vector2 Position;

        public Player(Map map, Vector2 position)
        {
            Map = map;
            Position = position;
        }

        public void Update()
        {
            if (Position.X < Map.Width)
            {
                Position.X++;
                if (Map.GetCell(Position.X, Position.Y) == '#')
                {
                    Health.ApplyDamage(10);
                }
            }
        }
    }
}