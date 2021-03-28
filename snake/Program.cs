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

            Console.SetWindowSize(80, 25);
            //Console.SetBufferSize(80, 25);

            HorizontailLine upLine = new HorizontailLine(0, 78, 0, '+');
            HorizontailLine downLine = new HorizontailLine(0, 78, 24, '+');
            verticalLine leftLine = new verticalLine(0, 24, 0, '+');
            verticalLine rightLine = new verticalLine(0, 24, 78, '+');

            upLine.draw();
            downLine.draw();
            leftLine.draw();
            rightLine.draw();

            point p = new point(7, 5, '*');
            snake snake = new snake(p, 4, direction.up);
            snake.draw();


            Console.ReadLine();
        }
     

    }
}