using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dl = 2;
            double r = 2;
            double d = (dl * Math.Sqrt(2)) /2;



            if (d <= r)
            {
                Console.WriteLine("Kwadrat zmieści się w podanym okręgu");
            }
            else
            {
                Console.WriteLine("Kwadrat nie zmieści się w podanym okręgu!!!");
            }

            Console.WriteLine("Wartość d = " + d);

            Console.ReadKey();
        }
    }
}
