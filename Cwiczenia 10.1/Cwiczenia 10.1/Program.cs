﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                Console.ReadKey(); 
        }
    }
}
