using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_volumen_esf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite el radio de la esfera  ");
            var rad = Console.ReadLine();
            var res = double.TryParse(rad, out double val);
            if (res==(true))
            {
                val = double.Parse(rad);
                double po =Math.Pow(val,3);
                double res1 = 4 * 3.1416 * po/3;
                Console.WriteLine($"el resutado es: {res1}");

                Console.ReadLine();
            }
            else
            {
                Console.Write("ud ha digitado una letra se necesitan numeros");
            }

        }
    }
}
