using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Menu_Raro
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Menu Raro");
            System.Console.WriteLine("1= Area de Cuadrado");
            System.Console.WriteLine("2= Promemdio");
            System.Console.WriteLine("3= Temperatura");
            System.Console.WriteLine("4= Densidad");
            System.Console.WriteLine("5= Masa");
            System.Console.WriteLine("6= Volumen");
            System.Console.WriteLine("7= Puntaje");
            System.Console.WriteLine("Elige una opcion");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Console.WriteLine("Area de Cuadrado");
                    System.Console.WriteLine("Inserte longitud");
                    int L = int.Parse(Console.ReadLine());
                    int exp = 2;
                    double A = Math.Pow(L, exp);
                    System.Console.WriteLine("El area del cuadrado es de: " + A);
                    break;
                case 2:
                    double sumaCalif = 0;
                    int x = 0;
                    System.Console.WriteLine("Promedio");
                    System.Console.WriteLine("Ingresa la Cantidad de Materias");
                    int N_Mat = int.Parse(Console.ReadLine());
                    for (int i = 0; i < N_Mat; i++)
                    {
                        Console.WriteLine("Ingresa la calificacion");
                        double calif = double.Parse(Console.ReadLine());
                        sumaCalif += calif;
                        x++;
                    }
                    double prom = sumaCalif / x;
                    Console.WriteLine("El promedio es de: " + prom);
                    break;
                case 3:
                    System.Console.WriteLine("Temperatura");
                    System.Console.WriteLine("Ingrese la Temperatura");
                    int Temperatura = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Presion");
                    int Presion = int.Parse(Console.ReadLine());
                    if (Presion == 200 && Temperatura == 100)
                    {
                        System.Console.WriteLine("Alarma");
                    }
                    else
                    {
                        System.Console.WriteLine("Normal");
                    }
                    break;
                case 4:
                    System.Console.WriteLine("Densidad");
                    System.Console.WriteLine("Ingrese la Masa");
                    double M = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese el Volumen");
                    double V = double.Parse(Console.ReadLine());
                    double D = M / V;
                    System.Console.WriteLine("La densidad es de: " + D);
                    break;
                case 5:
                    System.Console.WriteLine("Masa");
                    System.Console.WriteLine("Ingrese el Volumen");
                    double v = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Densidad");
                    double d = double.Parse(Console.ReadLine());
                    double m = v * d;
                    System.Console.WriteLine("La Masa es de: " + m);
                    break;
                case 6:
                    System.Console.WriteLine("Volumen");
                    System.Console.WriteLine("Ingrese la Masa");
                    double ma= double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Densidad");
                    double de= double.Parse(Console.ReadLine());
                    double vo = ma / de;
                    System.Console.WriteLine("El volumen es de: " + vo);
                    break;
                case 7:
                    System.Console.WriteLine("Puntaje");
                    System.Console.WriteLine("Ingrese su Puntaje");
                    int p = int.Parse(Console.ReadLine());
                    if (p >= 100)
                    {
                        System.Console.WriteLine("Puntaje Alto");
                    }
                    else
                        System.Console.WriteLine("Puntaje Bajo");
                    break;
                default:
                    System.Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
    }
}