using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake :figure
    {
        direction _direction = new direction ();
        public snake (point tail, int length, direction direction2)
        {
            _direction = direction2;
            pList = new List<point>();
            for (int i=0; i<length; i++)
            {
                point p = new point(tail);
                p.move(i, direction2);
                pList.Add(p);

            }
        }

        internal void move()
        {
            point tall = pList.First();
            pList.Remove(tall);
            point head = getNextPoint();
            pList.Add(head);

            tall.clear();
            head.draw();

        }

        public point getNextPoint()
        {
            point head = pList.Last();
            point nextPoint = new point(head);
            nextPoint.move(1, _direction);
            return nextPoint;
        }
    }
}
