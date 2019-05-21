using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11_p124
{
    class Program
    {       
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 2;
            Console.WriteLine("el polinomio es de la forma : ax^3 - bx^3 + cx - 7. los coeficientes son:\na = 3\nb = 5\nC = 2; ");
            Console.Write("digite el valor para x:  ");
            var num = Console.ReadLine();
            var res = double.TryParse(num, out double val);
            if (res == true)
            {
                val = double.Parse(num);
                double expo1 = Math.Pow(val, 5);
                double expo2 = Math.Pow(val, 3);
                double mul = c *val;
                double resultado = (a * expo1) - (b * expo2) + mul - 7;
                Console.Write($"Para x= {num}. 3x^5 - 5x^3 + 2x - 7 = {resultado}");
            }
            else
            {
                Console.Write("x es un valor numerico no es un caracter");
            }
            Console.ReadLine();
        }
    }
}
