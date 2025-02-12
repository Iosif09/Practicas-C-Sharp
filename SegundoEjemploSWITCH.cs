using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class SegundoEjemploSWITCH
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Menu Para Calcular Area de Figuras");
            System.Console.WriteLine("Calculo de Areas");
            System.Console.WriteLine("1 = Area del Circulo");
            System.Console.WriteLine("2 = Area del Trapecio");
            System.Console.WriteLine("3 = Area del Triangulo");
            System.Console.WriteLine("4 = Area del Hexagono");
            System.Console.WriteLine("5 = Area del Rombo");
            System.Console.WriteLine("Elija una Opcion");
            int opci = int.Parse(Console.ReadLine());
            switch (opci)
            {
                case 1:
                    System.Console.WriteLine("Area del Circulo");
                    System.Console.WriteLine("Ingresar Medida del Radio");
                    double r = double.Parse(Console.ReadLine());
                    int exp = 2;
                    double AC = (Math.PI) * (Math.Pow(r, exp));
                    System.Console.WriteLine($"El Area del Circulo cuyo Radio de {r} es: " + AC);
                    break;
                case 2:
                    System.Console.WriteLine("Area del Trapecio");
                    System.Console.WriteLine("Ingrese la Medida de Base Mayor");
                    double BM = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Medida de Base Menor");
                    double bm = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Medida de la Altura");
                    double HTP = double.Parse(Console.ReadLine());
                    double ATP = ((BM + bm) * HTP) / 2;
                    System.Console.WriteLine($"El Area del Trapecio cuyo Base Mayor de {BM}, Base Menor de {bm} y altura de {HTP} es de: " + ATP);
                    break;
                case 3:
                    System.Console.WriteLine("Area del Triangulo");
                    System.Console.WriteLine("Ingrese la Medida de la Base");
                    double BT = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Medida de la Altura");
                    double HT = double.Parse(Console.ReadLine());
                    double AT = (BT * HT) / 2;
                    System.Console.WriteLine($"El Area del Triangulo cuyo Base de {BT} y Altura de {HT} es: " + AT);
                    break;
                case 4:
                    System.Console.WriteLine("Area del Hexagono");
                    System.Console.WriteLine("Ingrese la Medida de uno de los Lados del Hexagono");
                    double LH = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese el Apotema del Hexagono");
                    double Apo = double.Parse(Console.ReadLine());
                    double PH = (6 * LH);
                    double AHex = (PH * Apo) / 2;
                    System.Console.WriteLine($"El Area del Hexagono cuyo Lado es {LH} y apotema de {Apo} es: " + AHex);
                    break;
                case 5:
                    System.Console.WriteLine("Area del Rombo");
                    System.Console.WriteLine("Ingrese la Medida de la Diagonal Mayor");
                    double DM = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Medida de la Diagonal Menor");
                    double dm = double.Parse(Console.ReadLine());
                    double AR = (DM * dm) / 2;
                    System.Console.WriteLine($"El Area del Rombo cuyo Diagonal Mayor es {DM} y Diagonal Menor es {dm} es: " + AR);
                    break;
            }
        }
    }
}
