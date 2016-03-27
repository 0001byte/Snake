using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sim;

        public Point() { }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sim = p.sim;
        }
        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

        public void Clear()
        {
            sim = ' ';
            Draw();
        }

        public void Move (int i, Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                x -= i;
            }
            if (direction == Direction.RIGHT)
            {
                x += i;
            }
            if (direction == Direction.TOP)
            {
                y -= i;
            }
            if (direction == Direction.BOTTOM)
            {
                y += i;
            }
        }
    }

}