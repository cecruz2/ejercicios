using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12_p_124
{
    class Program
    {
        // esta comvirtiendo un caracter digitado por el usuario a un numero entero utilizando el char y en ves del parse 
       public class test
        {
            public static void Main(string[] args)
            {
                char car = '\0';

                Console.Write("caracter:  ");
                car = (char)Console.Read();
                Console.WriteLine(car.ToString());
                
                Console.ReadKey();
                Console.ReadLine();

            }

        }
    }
}
