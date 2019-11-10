using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool zmienna;
            int a = 3;
            int b = 3; 

            switch (a%b)
            {
                case 0:
                    Console.WriteLine("Modulo równa się 0");
                    zmienna = true;
                    Console.ReadKey();
                    break;
                default:
                    zmienna = false;
                    Console.WriteLine("Modulo nie równa się 0!!!");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
