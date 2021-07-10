using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Snake : Line
    {
        Direction Direction;

        public Snake(Point tail, int length, Direction direction)
        {
            Direction = direction;

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                Points.Add(p);
            }
        }

        public void Move()
        {
            Point tail = Points.First();
            Points.Remove(tail);
            Point head = GetNextPoint();
            Points.Add(head);

            tail.Clear();            
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = Points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void KeyHandler(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    Direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    Direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    Direction = Direction.DOWN;
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                Points.Add(food);
                return true;
            }

            return false;
        }
    }
}
