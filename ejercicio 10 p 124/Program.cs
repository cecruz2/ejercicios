using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_p_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("el  polinomio es de la forma: prop = 3x^5-5^x3+2x-7");
            Console.Write("digite el valor para x  ");
            var num = Console.ReadLine();
            var res = double.TryParse(num, out double valor);
            if (res==true)
            {
                valor = double.Parse(num);
                double expo1 = Math.Pow(valor, 5);
                double expo2 = Math.Pow(valor, 3);
                double mul = 2 * valor;
                double resultado = (3 * expo1) - (5 * expo2) + mul - 7;
                Console.Write($"Para x= {num}. 3x^5 - 5x^3 + 2x - 7 = {resultado}");
            }
            else
            {
                Console.Write("el valor digitado es un caracter, digite solo numeros");
            }
            Console.ReadLine();

        }
    }
}
