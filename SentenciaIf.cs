using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class SentenciaIf
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Funcion IF / ELSE");
            System.Console.WriteLine("Ingrese su año de Nacimiento:");
            double AN = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Año Actual");
            double AA = double.Parse(Console.ReadLine());
            double Ed = AA - AN;
            if (Ed >= 18)
            {
                System.Console.WriteLine("Usted es Mayor de edad :D");
            } else
            {
                System.Console.WriteLine("Usted es Menor de edad :c");
            }
        }
    }
}
