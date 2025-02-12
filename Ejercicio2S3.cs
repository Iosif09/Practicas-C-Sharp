using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Ejercicio2S3
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa tu Calificacion de Examen");
            double examen = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa los Programas Entregados");
            int programas_entregados = int.Parse(Console.ReadLine());
            if (examen >= 70 && programas_entregados >= 8)
            {
                System.Console.WriteLine("Aprobado");
            }
            else
            {
                System.Console.WriteLine("Reprobado");
            }
        }
    }
}
