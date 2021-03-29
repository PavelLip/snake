using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void move(int offset, direction direction)
        {
            if (direction == direction.rigth)
            {
                x = x + offset;
            }   
            else if (direction == direction.left)
            {
                x = x - offset;
            }
            else if (direction == direction.up)
            {
                y = y - offset;
            }
            else if (direction == direction.down)
            {
                y = y + offset;
            }
        }

        public void clear ()
        {
            sym = ' ';
            draw();
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
