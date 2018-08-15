using System.Drawing;

namespace DrawFigure_1_
{
    struct Ellipse : IFigure
    {
        public Ellipse(Point startPoint, Color color, Size size)
        {
            StartPoint = startPoint;
            Color = color;
            Size = size;
        }

        public Point StartPoint  { get; }
        public Color Color { get; }
        public Size Size { get; }

    }
}