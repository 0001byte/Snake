using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetBufferSize( 80, 25 );

            HorizontLine hlLineTop = new HorizontLine(0, 78, 0, '+');
            HorizontLine hlLineBottom = new HorizontLine(0, 78, 24, '+');
            VerticalLine vlLineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine vlLineRight = new VerticalLine(0, 24, 78, '+');

            vlLineLeft.Draw();
            vlLineRight.Draw();
            hlLineTop.Draw();
            hlLineBottom.Draw();

            Point pStart = new Point(12, 5, 'o');
            int iStartLength = 3;
            Direction dStartDirection=Direction.RIGHT;

            Snake snake = new Snake(pStart, iStartLength, dStartDirection);
            snake.Draw();
            new Point(22, 5, 'x').Draw();
            int step = 0;
            while (true)
            {
                step++;
                if (Console.KeyAvailable)
                {
                    snake.SetDirection(Console.ReadKey().Key);
                }

                Thread.Sleep(500);
                snake.Move();

                if(step==8)
                    snake.Eat(new Point(12, 5, 'x'));
            }

            
        }
    }
}
