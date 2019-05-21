using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9_p124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite su nombre");
            string nom = Console.ReadLine();
            Console.Write("digite el año de nacimiento");
            var num =Console.ReadLine();
            var edad = int.TryParse(num, out int ed);
            if (edad==true)
            {
                ed = int.Parse(num);
                int anios = 2030 - ed;
                Console.Write($"{nom} ud en el 2030 va a tener {anios} años");
                
            }
            else
            {
                Console.Write("dijite el año en numero");
            }
            Console.ReadLine();
        }
    }
}
