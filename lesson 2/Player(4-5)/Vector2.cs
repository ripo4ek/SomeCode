namespace Player
{
    class Vector2
    {
        public int X, Y;

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 vector, int num)
        {
            vector.X += num;
            vector.Y += num;
            return vector;
        }
        public static Vector2 operator +(Vector2 vector, Vector2 vector2)
        {
            return new Vector2(vector.X + vector2.X, vector.Y + vector2.Y);
        }
        public static Vector2 operator *(Vector2 vector, int num)
        {
            vector.X *= num;
            vector.Y *= num;
            return vector;
        }
        public static Vector2 operator *(Vector2 vector, Vector2 vector2)
        {
            return new Vector2(vector.X * vector2.X, vector.Y * vector2.Y);
        }

    }
}