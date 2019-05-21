using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // elaborado por: Carlos Eduardo Cruz Aguilar

            string let = "q";
            foreach (byte c in System.Text.Encoding.UTF8.GetBytes(let.ToCharArray()))
            Console.Write(c.ToString()+"\n");

            string let2 = "Q";
            foreach (byte c in System.Text.Encoding.UTF8.GetBytes(let2.ToCharArray()))
            Console.Write(c.ToString());
            Console.ReadLine();
        }
       
    }
}
