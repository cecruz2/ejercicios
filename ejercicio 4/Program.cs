using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {           
            CEcuacion ecuacion = new CEcuacion(5, -1.7, 2, 3.5, 3,10.5 );
            Console.WriteLine(ecuacion.valora);
            Console.WriteLine(ecuacion.valorb);
            Console.WriteLine(ecuacion.valorc);
            Console.WriteLine(ecuacion.valord);
            Console.WriteLine(ecuacion.valork);
            Console.WriteLine(ecuacion.valorx);
            Console.ReadLine();
        }
        
    }
    class CEcuacion
    {
        //& public double Ecuacion (double a, double b, double c, double d, double k,double x);

        public double valora, valorb, valorc,valord,valork,valorx;
        public CEcuacion(double a, double b,double c,double d,double k, double x )
        {
            valora = a;
            valorb = b;
            valorc = c;
            valord = d;
            valork = k;
            valorx = x;


        }


    }
}
