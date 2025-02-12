using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class PrimerEjemploSWITCH
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Menu Para Resolver Operaciones Basicas");
            System.Console.WriteLine("1 = SUMA");
            System.Console.WriteLine("2 = RESTA");
            System.Console.WriteLine("3 = MULYIPLICACION");
            System.Console.WriteLine("4 = DIVISION");
            System.Console.WriteLine("Elija una Opcion");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Console.WriteLine("SUMA");
                    System.Console.WriteLine("Ingrese Primer Valor");
                    double S1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese Segundo Valor");
                    double S2 = double.Parse(Console.ReadLine());
                    double S = S1 + S2;
                    System.Console.WriteLine($"El Resultado de {S1} + {S2} es: " + S);
                    break;
                case 2:
                    System.Console.WriteLine("RESTA");
                    System.Console.WriteLine("Ingrese Primer Valor");
                    double R1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese Segundo Valor");
                    double R2 = double.Parse(Console.ReadLine());
                    double R = R1 - R2;
                    System.Console.WriteLine($"El Resultado de {R1} - {R2} es: " + R);
                    break;
                case 3:
                    System.Console.WriteLine("MULTIPLICACION");
                    System.Console.WriteLine("Ingrese Primer Valor");
                    double M1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese Segundo Valor");
                    double M2 = double.Parse(Console.ReadLine());
                    double M = M1 * M2;
                    System.Console.WriteLine($"El Resultado de {M1} por {M2} es: " + M);
                    break;
                case 4:
                    System.Console.WriteLine("DIVISION");
                    System.Console.WriteLine("Ingrese Primer Valor");
                    double D1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese Segundo Valor");
                    double D2 = double.Parse(Console.ReadLine());
                    double D = D1 / D2;
                    System.Console.WriteLine($"El Resultado de {D1} entre {D2} es: " + D);
                    break;
                default:
                    System.Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
    }
}
