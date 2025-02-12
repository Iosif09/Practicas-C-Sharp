using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class FormulaGeneral
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Calculo con Formula General");
            System.Console.WriteLine("Ingrese el Valor de A");
            double a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Valor de B");
            double b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Valor de C");
            double c = double.Parse(Console.ReadLine());
            double exp = 2;
            double b2 = Math.Pow(a, exp);
            double ac = a * c;
            double ac4 = ac * 4;
            double Rb4 = b2 - ac4;
            double Rb = Math.Sqrt(Rb4);
            double mb = b * -1;
            double MB = mb + Rb;
            double mB = mb - Rb;
            double a2 = a * 2;
            double P1 = MB / a2;
            double P2 = mB / a2;
            System.Console.WriteLine("X1 = " + P1);
            System.Console.WriteLine("X2 = " + P2);
        }
    }
}
