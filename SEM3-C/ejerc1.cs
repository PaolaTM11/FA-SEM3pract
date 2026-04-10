using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM3_C
{
    internal class ejerc1
    {
        static void Main(string[] args)
        {
            string n, c;
            Console.Write("Ingrese nombre:");
            n = Console.ReadLine();
            Console.WriteLine("Ingrese carrera:");
            c= Console.ReadLine();

            Console.WriteLine("\n------ IMPRESION CON + -----");
            Console.WriteLine(n+ ", BIENVENIDO AL CURSO FA DE LA CARRERA " + C);

            Console.WriteLine("\n-------IMPRESION CON $ ---------");
            Console.WriteLine($"{n},Bienvenido al curso FA de la carrera {c}");

            Console.ReadKey();

        }
    }
}
