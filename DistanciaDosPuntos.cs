using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class DistanciaDosPuntos
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Calculo de distancia entre dos puntos");
            System.Console.WriteLine("Ingrese el Valor del Primer Punto X");
            double X1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Valor del Primer Punto Y");
            double Y1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Valor del Segundo Punto X");
            double X2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Valor del Segundo Punto Y");
            double Y2 = double.Parse(Console.ReadLine());
            double exp = 2;
            double RX = X2 - X1;
            double RY = Y2 - Y1;
            double PX = Math.Pow(RX, exp);
            double PY = Math.Pow(RY, exp);
            double S = PX + PY;
            double d= Math.Sqrt(S);
            System.Console.WriteLine("La distancia es de: " + d);
        }
    }
}
