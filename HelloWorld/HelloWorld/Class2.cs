using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Class2
    {
        public void ZmienImie(string mojeImie)
        {
            mojeImie = "hahah zmienione";
        }


        public void ZmienImie(Class1 mojaKlasa)
        {
            mojaKlasa.Imie = "hahah zmienione";
        }
    }
}
