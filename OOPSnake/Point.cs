using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y =_y;
            symbol = _symbol;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case Direction.LEFT:
                    x += offset;
                    break;
                case Direction.RIGHT:
                    x -= offset;
                    break;
                case Direction.UP:
                    y += offset;
                    break;
                case Direction.DOWN:
                    y -= offset;
                    break;
            }                
        }
    }
}
