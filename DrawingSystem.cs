using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftwareSystem
{
    class DrawingSystem
    {

        Graphics g;
        Pen Pen;
        int xPosition, yPosition;

        public DrawingSystem(Graphics g)
        {
            this.g = g;
            xPosition = yPosition = 0;
            Pen = new Pen(Color.Black, 1);
        }

        //Drawing the line here
        public void DrawLine(int xDestination, int yDestination)
        {
            g.DrawLine(Pen, xPosition, yPosition, xDestination, yDestination);
            xPosition = xDestination;
            yPosition = yDestination;
        }

        public void MoveLine(int xDestination, int yDestination)
        {
            xPosition = xDestination;
            yPosition = yDestination;
        }

        //Drawing the square here
        public void SquareDrawing(int xDestination, int yDestination)
        {
            g.DrawRectangle(Pen, xPosition, yPosition, xPosition + xDestination, yPosition + yDestination);
            
        }

        //Drawing the circle here
        public void CircleDrawing(int xDestination, int yDestination)
        {
            // g.DrawEllipse(Pen, 10, 10, 200, 200);
          //  Rectangle rect = new Rectangle(0, 0, 200, 100);
             g.DrawEllipse(Pen, xPosition, yPosition, xDestination, yDestination);
           // g.DrawEllipse(Pen, rect);

        }

        //Drawing the triangle here
        public void TriangleDrawing(int xDestination, int yDestination)
        {
           Point[] a = { new Point(10, 10), new Point(200, 100), new Point(400, 100) };
           // Point[] a = { new Point(xPosition, yPosition), new Point(xPosition, yPosition), new Point(xPosition, yPosition) };
            g.DrawPolygon(Pen, a);
        }

    }
}
