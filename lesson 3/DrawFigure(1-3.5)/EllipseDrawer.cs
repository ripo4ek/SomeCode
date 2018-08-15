using System.Drawing;

namespace DrawFigure_1_
{
    class EllipseDrawer: DrawEntity
    {
        public Ellipse Ellipse;
        public EllipseDrawer(Ellipse ellipse)
        {
            Ellipse = ellipse;
        }
        public override void Draw(Graphics drawer)
        {
            base.Draw(drawer);
            Pen.Color = Ellipse.Color;
            Drawer.DrawEllipse(Pen,new System.Drawing.Rectangle(Ellipse.StartPoint,Ellipse.Size));
        }
    }
}