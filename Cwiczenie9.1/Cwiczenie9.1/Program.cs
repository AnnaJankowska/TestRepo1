using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 8;

            switch (z)
            {
                case 0:
                    Console.WriteLine("Liczba 0");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine("Liczba 1");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Liczba 2");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Liczba 3");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Liczba 4");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Liczba 5");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Liczba 6");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Liczba 7");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("Liczba 8");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("Liczba 9");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Liczna nie należy do przedziału 0-9.");
                    Console.ReadKey();
                    break;
                                     
            }
        }
    }
}
