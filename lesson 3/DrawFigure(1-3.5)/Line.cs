using System.Drawing;

namespace DrawFigure_1_
{
    struct Line : IFigure
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }
        public Color Color { get; }
        public Size Size { get; }
    
        public Line(Point startPoint , Point endPoint,Color color)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Color = color;
            Size = new Size(EndPoint.X - startPoint.X, EndPoint.Y - startPoint.Y);
        }
    };
}