using System.Drawing;

namespace DrawFigure_1_
{
    interface IFigure
    {
        Point StartPoint { get; }
        Size Size { get; }
        Color Color { get; }
    }
}