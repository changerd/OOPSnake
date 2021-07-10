﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Borders
            HorizontalLine topBorder = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomBorder = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftBorder = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightBorder = new VerticalLine(0, 24, 78, '+');
            topBorder.Draw();
            bottomBorder.Draw();
            leftBorder.Draw();
            rightBorder.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 10, Direction.RIGHT);
            snake.Draw();
            
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandler(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }           
        }       
    }
}
