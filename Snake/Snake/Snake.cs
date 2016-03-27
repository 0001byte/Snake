using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList= new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);

            Point head = GetNext();
            pList.Add(head);

            head.Draw();
            tail.Clear();
        }

        public void SetDirection(Direction _direction)
        {
            direction = _direction;
        }

        public void Eat(Point p)
        {

            Point head = GetNext();
            pList.Add(head);

            head.Draw();
        }

        public void SetDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                SetDirection(Direction.LEFT);
            }
            else if (key == ConsoleKey.RightArrow)
            {
                SetDirection(Direction.RIGHT);
            }
            else if (key == ConsoleKey.UpArrow)
            {
                SetDirection(Direction.TOP);
            }
            else if (key == ConsoleKey.DownArrow)
            {
                SetDirection(Direction.BOTTOM);
            }
        }

        internal Point GetNext()
        {
            Point head = new Point(pList.Last());
            head.Move(1, direction);

            return head;
        }
    }
}
