using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class ejerci3
    {
        static void Main(string[] args)
        {
            Console.Write("---Sistema de conversión monetario--- \n ");

            Console.Write("\nIngrese el monto en soles: ");
            double mo = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Convertir a dolares");
            Console.WriteLine("2. Convertir a Euros\n");

            Console.WriteLine("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    double dolares = mo / 3.75;
                    Console.WriteLine("\nDolares: " + dolares);
                    break;
                case 2:
                    double euros = mo / 4.95;
                    Console.WriteLine("\nEuros:" + euros);
                    break;
                default:
                    Console.WriteLine("Opción incorrecta!");
                    break;


            }

        }
    }
}
