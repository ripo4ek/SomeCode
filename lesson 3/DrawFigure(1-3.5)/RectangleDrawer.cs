using System.Drawing;

namespace DrawFigure_1_
{
    class RectangleDrawer: DrawEntity
    {
        public Rectangle Rectangle;

        public RectangleDrawer(Rectangle rectangle)
        {
            Rectangle = rectangle;
        }

        public override void Draw(Graphics drawer)
        {
            base.Draw(drawer);
            Pen.Color = Rectangle.Color;
            Drawer.DrawRectangle(Pen,new System.Drawing.Rectangle(Rectangle.StartPoint,Rectangle.Size));
        }
    }
}