using System.Drawing;

namespace DrawFigure_1_
{
    class DrawEntity : IDrawable
    {
        protected Pen Pen;
        protected Graphics Drawer;

        public virtual void Draw(Graphics drawer)
        {
            Drawer = drawer;
            Pen = new Pen(Color.Black);
        }

    }
}