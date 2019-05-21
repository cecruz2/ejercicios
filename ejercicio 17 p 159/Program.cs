using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17_p_159
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("vamos a adivinar el numero pensado por el ordenador solo tienes 10 intentos");
            int valor = 0;
            Random rdn = new Random();
            int a = rdn.Next(100);
            for (int i = 0; i < 10; i++)
            {                     
               Console.WriteLine("dijite el numero");
               var num = Console.ReadLine();
               var res = int.TryParse(num, out valor);
               if (res==true)
               {
                    valor = int.Parse(num);
                    if (valor==a)
                    {
                        Console.Write($"adivinaste el numero, el numero es  {a} ");
                        break;
                    }
                    else {
                        if (valor > a)
                        {
                            Console.WriteLine("el numero es menor");
                        }
                        else
                        {
                            Console.WriteLine("el numero es mayor");
                            
                        }
                    }
                    
               }
               else
               {
                  Console.Write("ud ha digitado un caracter ");
               }
            }
            
            Console.ReadKey();
        }
    }
}
