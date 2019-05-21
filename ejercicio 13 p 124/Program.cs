using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13_p_124
{
   public class test
    {
        public static  void Main(string[] args)
        {
            int car1 = 'A', car2 = 65, car3 = 0;
            car3 = car1 + 'a' - 'A';
            Console.WriteLine((char)car3 + " " + car3);//// el resultado o muestra es a 
            // esto sucede porque el char concatena los valores poer eso el resultado al ejecutar es a 97
            car3 = car2 + 32;
            Console.WriteLine((char)car3 + " " + car3);//el resultado es 97 

            Console.ReadLine();
        }
    }
}
