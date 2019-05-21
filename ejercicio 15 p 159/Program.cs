using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15_p_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vamos as evaluar la serie: 1/x+ay donde el limite inferior es 0, tu digitaras el limite superior\n y el valor para x y para y");
            Console.Write("dijita el valor para x  ");
            var num1 = Console.ReadLine();
            Console.Write("dijita el valor para y  ");
            var num2 = Console.ReadLine();
            Console.Write("dijita el valor para el limite  ");
            var lim = Console.ReadLine();
            var res3 = double.TryParse(lim, out double limite);
            var res = double.TryParse(num1, out double valx);
            var res2 = double.TryParse(num2, out double valy);
            if ((res==true)&&(res2==true)&&(res3==true))
            {
                valx = double.Parse(num1);
                valy = double.Parse(num2);
                limite = int.Parse(lim);
                double resul = 0;
                for (int i = 1; i < limite; i++)
                {                   
                    double resumul = i * valy;
                    double resultado = 1/resumul;
                    resul += resultado;                   
                }
                Console.WriteLine($"el resultado de la sumatoria< es {resul}");

            } 
            else
            {
                Console.Write("has digitado una letra");
            }

            Console.ReadKey();
        }
    }
}
