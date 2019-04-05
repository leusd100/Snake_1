using System.Collections.Generic;

namespace snake
{
    class VLine : Figure
    {

        public VLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }


    }
}
