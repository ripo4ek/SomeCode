using System.Drawing;

namespace DrawFigure_1_
{
    struct Rectangle: IFigure
    {
        public Rectangle(Point startPoint, Color color, Size size) : this()
        {
            StartPoint = startPoint;
            Color = color;
            Size = size;
        }

        public Point StartPoint { get; }
        public Color Color { get; }
        public Size Size { get; }
    }
}