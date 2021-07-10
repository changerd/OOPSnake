using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char symbol;

        Random random = new Random();

        public FoodCreator(int width, int height, char symb)
        {
            mapWidth = width;
            mapHeight = height;
            symbol = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symbol);
        }
    }
}
