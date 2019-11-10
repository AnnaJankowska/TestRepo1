using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_10._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i < 21)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
