using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 5;
            char symbol1 = '$';

            Draw(x1, y1, symbol1);

            int x2 = 5;
            int y2 = 10;
            char symbol2 = '#';

            Draw(x2, y2, symbol2);

            Console.ReadKey();
        }

        static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
