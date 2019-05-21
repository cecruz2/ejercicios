using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14_p_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite el un numero para el primer intervalo");
            var num1 = Console.ReadLine();///a
            Console.Write("digite el un numero para el segundo intevalo");
            var num2 = Console.ReadLine();///b
            var res = int.TryParse(num1, out int val1);
            var res1 = int.TryParse(num2, out int val2);
            if ((res = true)&& (res1 = true))
            {
                val1 = int.Parse(num1);///a
                val2 = int.Parse(num2);///b
                if ((val1 < 0) || (val2 < 0)&&(val1==val2))
                {
                    Console.Write("¡ERROR! los intervalos son negativos o los intervalos son iguales");
                }
                else
                {
                    if (val1 > val2)
                    {
                        var auxiliar = val1;
                        val1 = val2;
                        val2 = auxiliar;
                    }

                    int suma = 0;
                    for (int i = val1; i <= val2; i++)
                    {
                        Console.WriteLine(i);
                        var modu = i % 5;

                        if (modu == 0)
                        {
                            suma += i;
                        }
                    }

                    Console.WriteLine($"la suma de los multiplos de 5 es:  {suma}");
                }
            }
            else
            {
                Console.Write("para realizar el intervalo  se nececitan numeros no letras");
            }
            Console.ReadKey();
            

        }
    }
}
