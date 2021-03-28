using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class verticalLine : figure
    {
        public verticalLine(int topy, int botttony, int x, char sym)
        {
            pList = new List<point>();
            for (int y = topy; y <= botttony; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
