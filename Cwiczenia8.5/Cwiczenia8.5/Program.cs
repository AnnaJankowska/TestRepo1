using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 1;
            int w = 3;
            int h = 8;

            int p1 = 7;
            int p2 = 9;

            if (x <= p1 && p1 <= (x + w)  && y <= p2 && p2 <= (y + h))
            {
                Console.WriteLine("Punkt znajduje się w obrębie prostokąta.");
            }
            else
            {
                Console.WriteLine("Punkt znajduje się poza polem prostokąta.");
            }

            Console.ReadKey();
        }
    }
}
