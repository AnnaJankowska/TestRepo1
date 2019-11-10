using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string imie = "Dawid";
            var mojaKls = new Class1();
            mojaKls.Imie = "Dawid";

            var klasa = new Class2();
            klasa.ZmienImie(mojaKls);
            klasa.ZmienImie(imie);
            Console.WriteLine(mojaKls.Imie);


            Console.ReadLine();


        }
    }
}
