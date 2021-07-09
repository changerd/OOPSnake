using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    public class HorizontalLine
    {
        List<Point> Points;

        public HorizontalLine(int xLeft, int xRight, int y, char symb) 
        {
            Points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Points.Add(new Point(x, y, symb));
            }            
        }

        public void Draw()
        {
            foreach(Point p in Points)
            {
                p.Draw();
            }
        }
    }
}
