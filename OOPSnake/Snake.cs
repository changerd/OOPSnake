using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Snake : Line
    {
        public Snake(Point tail, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                Points.Add(p);
            }
        }
    }
}
