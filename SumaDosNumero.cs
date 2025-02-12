using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class SumaDosNumero
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Inserte 1er Numero");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserte 2do Numero");
            int N2 = int.Parse(Console.ReadLine());
            int S = N1 + N2;
            System.Console.WriteLine("El resultado es: " + S);
            Console.ReadKey();
        }
    }
}
