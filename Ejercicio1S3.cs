using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Ejercicio1S3
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese su Puntaje");
            int punt = int.Parse(Console.ReadLine());
            if (punt >= 100)
            {
                System.Console.WriteLine("Su Puntaje es Alto");
            }
            else
            {
                System.Console.WriteLine("Su Puntaje es Bajo");
            }
        }
    }
}
