using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class foodCreator
    {
        int mapWight;
        int mapHeigth;
        char sym;

        Random random = new Random();

        public foodCreator (int mapWight, int mapHeigth, char sym)
        {
            this.mapWight = mapWight;
            this.mapHeigth = mapHeigth;
            this.sym = sym;
        }

        public point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHeigth - 2);

           // x = 12;
            //y = 5;

            return new point(x, y, sym);
        }
    }
}
