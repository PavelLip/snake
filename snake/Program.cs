using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            point p1 = new point(1, 3, '*');
            p1.draw();

            point p2 = new point(4, 5, '#');
            p2.draw();
            */

            HorizontailLine linex = new HorizontailLine(5, 10, 8, '+');
            linex.draw();

            verticalLine liney = new verticalLine(5, 4, 14, '+');
            liney.draw();

            Console.ReadLine();
        }
     

    }
}