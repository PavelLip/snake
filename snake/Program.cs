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
            
            point p1 = new point(1, 3, '*');
            p1.draw();

            point p2 = new point(4, 5, '#');
            p2.draw();

            point p3 = new point(2, 7, '&');
            p3.draw();

            point p4 = new point(3, 4, '^');
            p4.draw();
            

            List<point> plist = new List<point>();
            plist.Add (p1);
            plist.Add (p2);
            plist.Add (p3);
            plist.Add (p4);





            Console.ReadLine();
        }
     

    }
}
