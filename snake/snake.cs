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

        internal void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = direction.left;
            else if (key == ConsoleKey.RightArrow)
                _direction = direction.rigth;
            else if (key == ConsoleKey.UpArrow)
                _direction = direction.up;
            else if (key == ConsoleKey.DownArrow)
                _direction = direction.down;
        }   

        internal bool eat (point food)
        {
            point head = getNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;

        }


    }
}
