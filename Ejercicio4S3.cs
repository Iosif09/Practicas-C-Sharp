using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Ejercicio4S3
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese la Temperatura");
            int Temperatura = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la Presion");
            int Presion = int.Parse(Console.ReadLine());
            if (Presion == 200 && Temperatura == 100)
            {
                System.Console.WriteLine("Alarma");
            }
            else
            {
                System.Console.WriteLine("Normal");
            }
        }
    }
}
