using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Line
    {
        protected List<Point> Points;

        public Line()
        {
            Points = new List<Point>();
        }

        public void Draw()
        {
            foreach(Point p in Points)
            {
                p.Draw();
            }    
        }

        public bool IsHit(Line line)
        {
            foreach(Point p in Points)
            {
                if(line.IsHit(p))
                {
                    return true;
                }
            }

            return false;
        }

        bool IsHit(Point point)
        {
            foreach(Point p in Points)
            {
                if(p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
