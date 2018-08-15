using System.Collections.Generic;
using System.Drawing;

namespace DrawFigure_1_
{
    class PictureConstructor
    {
        private readonly List<IDrawable> _drawables = new List<IDrawable>();
        private Bitmap _canvas;
        private Graphics _drawer;

        public PictureConstructor(Bitmap canvas)
        {
            _canvas = canvas;
            _drawer = Graphics.FromImage(canvas);
            _drawer.FillRectangle(Brushes.White, new System.Drawing.Rectangle(0, 0, canvas.Width, canvas.Height));
        }

        public void Add(IDrawable draw)
        {
            _drawables.Add(draw);
        }

        public void Print()
        {
            foreach (var drawable in _drawables)
            {
                drawable.Draw(_drawer);
            }
            _canvas.Save("canvas.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}