using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Net;
using DrawFigure_1_;
using Rectangle = System.Drawing.Rectangle;

namespace DrawFigure_1_
{
    class Program
    {
       
        static void Main(string[] args)
        {
           var test = new PictureConstructor(new Bitmap(100,100));
            test.Add(new LineDrawer(new Line(new Point(10,10),new Point(10,50),Color.Black)));
            test.Add(new EllipseDrawer(new Ellipse(new Point(10, 10),Color.Red,new Size(20,20))));
            test.Add( new RectangleDrawer(new Rectangle(new Point(10,20),Color.Brown, new Size(20,20) )));
            test.Print();

        }

        
    }
}