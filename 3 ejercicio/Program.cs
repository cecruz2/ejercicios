using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // elaborado por: Carlos Eduardo Cruz Aguilarç

            double a = 5, b = - 1.7, c = 2, d = 3.5, k = 3, x = 10.5;
            double expo1, expo2, expo3;
            expo1 = Math.Pow(x, 4);
            expo2 = Math.Pow(x, 3);
            expo3 = Math.Pow(x, 2);
            double resultado = (a*expo1) + (b*expo2) - (c*expo3)  + (d * x) + k;
        }
    }
}
