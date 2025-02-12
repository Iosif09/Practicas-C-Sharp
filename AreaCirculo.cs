using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class AreaCirculo
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Area del Circulo");
            System.Console.WriteLine("Ingresar Medida del Radio");
            double r = double.Parse(Console.ReadLine());
            int exp = 2;
            double AC = (Math.PI) * (Math.Pow(r, exp));
            System.Console.WriteLine($"El Area del Circulo cuyo Radio de {r} es: " + AC);
        }
    }
}
