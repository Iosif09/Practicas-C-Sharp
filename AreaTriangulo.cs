using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class AreaTriangulo
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese la Medida de la Base");
            double BT = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la Medida de la Altura");
            double HT = double.Parse(Console.ReadLine());
            double AT = (BT * HT) / 2;
            System.Console.WriteLine("El Area del Triangulo es: " + AT);
        }
    }
}
