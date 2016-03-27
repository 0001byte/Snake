using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine:Figure
    {
        public HorizontLine(int leftX, int rightX, int y, char sim)
        {
            pList = new List<Point>();

            for (int x = leftX; x <= rightX; x++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
    }
}
