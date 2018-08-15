using System.Drawing;

namespace DrawFigure_1_
{
    //TODO: ДОДЕЛАТЬ
    struct Pyaramid 
    {
        public int  Quantity { get; }
        public Point StartPoint { get; }
        public Rectangle[] Rectangles { get; private set; }

        public Pyaramid(int quantity, Point startPoint)
        {
            Quantity = quantity;
            Rectangles = new Rectangle[quantity];
            StartPoint = startPoint;
        }

        private void Builder()//TODO: ДОДЕЛАТЬ
        {
            Point drawPoint = StartPoint;
            for (int i = 0; i < Rectangles.Length; i++)
            {
                Rectangles[i] = new Rectangle(drawPoint,Color.Brown,new Size());
            }
        }

         
    }
}