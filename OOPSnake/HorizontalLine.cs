using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class HorizontalLine : Line
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symb) 
        {
            Points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Points.Add(new Point(x, y, symb));
            }            
        }
    }
}
