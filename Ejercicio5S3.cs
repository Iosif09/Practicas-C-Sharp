using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Ejercicio5S3
    {
          void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese el Primer Numero");
            double N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Segundo Numero");
            double N2 = int.Parse(Console.ReadLine());
            double D = N1 / N2;
            double R = N1 % N2;
            if (R == 0)
             {
                 System.Console.WriteLine($"El resultado es: {D} por lo tanto, Es Exacto");
             }
            else
             {
                 System.Console.WriteLine($"El Resultado es: {D} por lo tanto No es Exacto");
             }
        }
    }
}
