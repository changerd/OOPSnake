using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class VerticalLine : Line
    {
        public VerticalLine(int yTop, int yBot, int x, char symb)
        {
            Points = new List<Point>();
            for(int y = yTop; y <= yBot; y++)
            {
                Points.Add(new Point(x, y, symb));
            }            
        }        
    }
}
