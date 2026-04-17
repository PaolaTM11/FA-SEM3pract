using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM3_C
{
    internal class Ejerc4
    {
       
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero decimal:");

            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Raíz cuadrada:{Math.Sqrt(num)}");
            Console.WriteLine($"Redondeado:{Math.Round(num, 0)}");
            Console.WriteLine($"Al cubo: {Math.Pow(num, 3)}");
            Console.WriteLine($"Raíz  cubica:{Math.Pow(num, 1 / 3d)}");

        }

    }
}
