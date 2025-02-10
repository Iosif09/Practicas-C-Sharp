using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Area_de_Trapecio
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Insertar base mayor");
            double BM = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Insertar base menor");
            double bme = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Insertar altura");
            double h = double.Parse(Console.ReadLine());
            double A = ((BM + bme) * h / 2);
            System.Console.WriteLine("El area es de " + A);
            Console.ReadKey();
        }
    }
}
