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

        public void DrawLine(int xDestination, int yDestination)
        {
            g.DrawLine(Pen, xPosition, yPosition, xDestination, yDestination);
            xPosition = xDestination;
            yPosition = yDestination;
        }

        public void SquareDrawing(int width)
        {
            g.DrawRectangle(Pen, xPosition, yPosition, xPosition + width, yPosition + width);
        }

    }
}
