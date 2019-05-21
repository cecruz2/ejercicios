using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16_p_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   programa para saber el numero del tarot");
            Console.Write("digite el dia de nacimiento ");
            var dia = Console.ReadLine();
            Console.Write("digite el mes de nacimiento ");
            var mes = Console.ReadLine();
            Console.Write("digite el año de nacimiento ");
            var an = Console.ReadLine();
            var res1 = int.TryParse(dia, out int di);
            var res2 = int.TryParse(mes, out int me);
            var res3 = int.TryParse(an, out int ani);
            if ((res1 == true)&& (res2 == true) && (res3 == true))
            {
                di = int.Parse(dia);
                me = int.Parse(mes);
                ani = int.Parse(an);
                if (((di<=31) && (di > 0))&&((me<=12)&&(me >0))&&((ani<2020)&&(ani>1880)))
                {
                    var resul1 = di + me + ani;
                    int s = 0;
                    while (resul1>0)
                    {
                        s = s + resul1 % 10;
                        resul1 = resul1 / 10;
                    }
                    int resul2 = s;
                    int s2 = 0;
                    while (resul2>0)
                    {
                        s2 = s2 + resul2 % 10;
                        resul2 = resul2 / 10;
                    }
                    Console.Write($"el numero del tarot es: {s2}");
                }
                else
                {
                    Console.WriteLine("algun valor esta fuera de los rangos permitidos");
                }

            }else
            {
                Console.WriteLine(" las fechas se digitan en numero");
            }
            Console.ReadLine();
        }
    }
}
