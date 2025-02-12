using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Ejercicio3S3
    {
         void Main(string[] args)
        {
            double Gasto0 = 0;
            System.Console.WriteLine("Ingrese su Ahorro");
            double Ahorro = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese su Gasto");
            double Gasto = double.Parse(Console.ReadLine());
            if (Ahorro > Gasto)
            {
                double Solvente = Ahorro - Gasto;
                System.Console.WriteLine($"Solvente  Ahorro: {Solvente} Gasto: {Gasto0}");
            }
            else
            {
                System.Console.WriteLine("Estas en Quiebra");
            }
        }
    }
}
