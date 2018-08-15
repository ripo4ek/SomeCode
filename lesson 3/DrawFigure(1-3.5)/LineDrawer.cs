using System.Drawing;

namespace DrawFigure_1_
{
    class LineDrawer: DrawEntity
    {
        public Line Line;

        public LineDrawer(Line line)
        {
            Line = line;
        }

        public override void Draw(Graphics drawer)
        {
            base.Draw(drawer);
            Pen.Color = Line.Color;
            Drawer.DrawLine(Pen, Line.StartPoint,Line.EndPoint);
        }
    }
}