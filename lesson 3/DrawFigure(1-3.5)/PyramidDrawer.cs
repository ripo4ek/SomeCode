using System.Drawing;

namespace DrawFigure_1_
{
    class PyramidDrawer : DrawEntity
    {
        public Pyaramid Pyaramid;

        public PyramidDrawer(Pyaramid pyaramid)
        {
            Pyaramid = pyaramid;
        }
        public override void Draw(Graphics drawer)
        {
            base.Draw(drawer);

            foreach (var rectangle in Pyaramid.Rectangles)
            {
                new RectangleDrawer(rectangle);
            }
        }
    }
}