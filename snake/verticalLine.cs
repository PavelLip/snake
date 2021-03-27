using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class verticalLine
    {
        List<point> pList;
        public verticalLine(int x, int topy, int botttony, char sym)
        {
            pList = new List<point>();
            for (int y = topy; y <= botttony; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }

        public void draw()
        {
            foreach (point p in pList)
            {
                p.draw();
            }
        }
    }
}
