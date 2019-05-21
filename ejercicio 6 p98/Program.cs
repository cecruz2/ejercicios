using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_p98
{
    class Program
    {
        
    }
    // Elaborado por Carlos Cruz
    class CApGrados
    {
        const int limInferior = -20;
        const int limSuperior = 50;
        const int incremento = 10;
        public static float ObtenerFahrenheit(float gradosCent)
        {
            return 9/5 * gradosCent + 32;///la salida de datos de equivalencia cambian, ya que al modificar los limtes y el incremento toma otro rango.
            ///por que al anteponerle la F no comvierte el valor
        }
        public static void Main(string[] args)
        {
            int gradosCent = limInferior;
            float gradosFahr = 0;
            while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);
                Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent, gradosFahr);
                gradosCent += incremento;
                Console.ReadLine();
            }
        }
    }
}
