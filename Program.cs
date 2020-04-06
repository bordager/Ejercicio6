using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca primer numero");
            string numero1;
            numero1 = Console.ReadLine();
            Console.WriteLine("Introduzca segundo numero");
            string numero2;
            numero2 = Console.ReadLine();

            long resultado = (int.Parse(numero1) + int.Parse(numero2)) * (int.Parse(numero1) - int.Parse(numero2));

            Console.WriteLine("El resultado es " + resultado);

            Console.Read(); 
        }
    }
}
