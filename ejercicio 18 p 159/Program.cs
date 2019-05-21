using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_18_p_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la ecuacio es de la forma ax^2+bx+c");
            Console.Write("digite el valor para a  ");
            var num1 = Console.ReadLine();
            Console.Write("digite el valor para b  ");
            var num2 = Console.ReadLine();
            Console.Write("digite el valor para c  ");
            var num3 = Console.ReadLine();
            var res1 = double.TryParse(num1, out double val1);
            var res2= double.TryParse(num2, out double val2);
            var res3= double.TryParse(num3, out double val3);
            if ((res1 == true) && (res2 == true) && (res3 == true))
            {
                val1 = double.Parse(num1);//a
                val2 = double.Parse(num2);//b
                val3 = double.Parse(num3);//c
                if ((val1 == 0) && (val2 == 0))
                {
                    Console.WriteLine("la ecuacion es degenerada");
                }
                if ((val1 == 0) && (val2 != 0))
                {
                    Console.WriteLine("existe una raiz co valor -c/b");
                }
                double po = Math.Pow(val2, 2); 
                double  mul=val1 * val3;
                double res = po - 4 * mul;
                double po2 = Math.Sqrt(res);
                if (res>=0)
                {
                    Console.WriteLine("  Hay dos raices reales ");
                }
                if (res<0)
                {
                    Console.WriteLine("  Hay dos raices complejas de la forma x+yj,x-yj");
                }
                else
                {
                    double resp = -val2 + po2 / 2 * val1;
                    double resn = -val2 - po2 / 2 * val1;
                    Console.Write($"la respuesta positiva es: {resp} \n la respuesta negativa es:  {resn}");
                }
            }
            else
            {
                Console.Write("no se aceptan caracteres");
            }
            
            Console.ReadKey();
        }
    }
}
