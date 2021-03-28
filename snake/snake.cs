using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake :figure
    {
        public snake (point tail, int length, direction direction2)
        {
            pList = new List<point>();
            for (int i=0; i<length; i++)
            {
                point p = new point(tail);
                p.move(i, direction2);
                pList.Add(p);

            }
        }

    }
}
