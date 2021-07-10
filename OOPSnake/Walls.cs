using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Walls
    {
        List<Line> WallList;

        public Walls(int mapWidth, int mapHeight)
        {
            WallList = new List<Line>();

            //Borders
            HorizontalLine topBorder = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomBorder = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftBorder = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightBorder = new VerticalLine(0, mapHeight-1, mapWidth - 2, '+');

            WallList.AddRange(new List<Line> { topBorder, bottomBorder, leftBorder, rightBorder });
        }

        public void Draw()
        {
            foreach(Line wall in WallList)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Line line)
        {
            foreach(Line wall in WallList)
            {
                if(wall.IsHit(line))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
