using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_p98
{
    class CApGrados
    {
        
       
        public static void Main(string[] args)
        {

            int gradosCent = CGrados.limInferior;
            float gradosFahr = 0;
            while (gradosCent <= CGrados.limSuperior)
            {
                gradosFahr = CGrados.ObtenerFahrenheit(gradosCent);
                Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent, gradosFahr);
                gradosCent += CGrados.incremento;
                
            }
            Console.ReadLine();
        }       
        
    }
    static class CGrados
    {
        public const int limInferior = -20;
        public const int limSuperior = 50;
        public const int incremento = 10;
        public static float ObtenerFahrenheit(float gradosCent)
        {
            return 9 / 5 * gradosCent + 32;
        }
        //public static void Main(string[] args)
        //{
        //    int gradosCent = limInferior;
        //    float gradosFahr = 0;
        //    while (gradosCent <= limSuperior)
        //    {
        //        gradosFahr = ObtenerFahrenheit(gradosCent);
        //        Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent, gradosFahr);
        //        gradosCent += incremento;

        //    }
        //}
    }


}
