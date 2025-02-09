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
                    System.Console.WriteLine("1 = Farenhei a Celciurs");
                    System.Console.WriteLine("2 = Celciurs a Farenhei");
                    System.Console.WriteLine("3 = Farenhei a Kelvins");
                    System.Console.WriteLine("4 = Kelvins a Farenhei");
                    System.Console.WriteLine("5 = Celciurs a Kelvins");
                    System.Console.WriteLine("6 = Kelvins a Celciurs");
                    System.Console.WriteLine("Elige una opcion");
                    int opc =int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            System.Console.WriteLine("Farenhei a Celciurs");
                            System.Console.WriteLine("Ingrese los Grados Farenhei");
                            double F = double.Parse(Console.ReadLine());
                            double C = (F - 32) / 1.8;
                            System.Console.WriteLine("Los Grados Celsius son: " + C);
                            break; 
                        case 2:
                            System.Console.WriteLine("Celsius a Farenheit");
                            System.Console.WriteLine("Ingrese los Grados Celsius");
                            double c = double.Parse(Console.ReadLine());
                            double f = (c * 1.8) + 32;
                            System.Console.WriteLine("Los grados Farenheit son:  " + f);
                            break;
                        case 3:
                            System.Console.WriteLine("Convertir Farenheit a Kelvins");
                            System.Console.WriteLine("Ingrese Grados Farenheit");
                            double fa = double.Parse(Console.ReadLine());
                            double K = ((fa - 32) / 1.8) + 273.15;
                            System.Console.WriteLine("Los grados kelvins son: " + K);
                            break;
                        case 4:
                            System.Console.WriteLine("Kelvins a Farenheit");
                            System.Console.WriteLine("Ingrese grados Kelvin");
                            double k = double.Parse(Console.ReadLine());
                            double far = ((k - 273.15) * 1.8) + 32;
                            System.Console.WriteLine("Los grados farenheit son: " + far);
                            break;
                        case 5:
                            System.Console.WriteLine("Celciurs a Kelvins");
                            System.Console.WriteLine("Ingrese grados Celsius");
                            double Cel = double.Parse(Console.ReadLine());
                            double Ke = Cel + 273.15;
                            System.Console.WriteLine("Los grados kelvins son: " + Ke);
                            break;
                        case 6:
                            System.Console.WriteLine("Kelvins a Celciurs");
                            System.Console.WriteLine("Ingrese grados Kelvins");
                            double kel = double.Parse(Console.ReadLine());
                            double Celsius = kel - 273.15;
                            System.Console.WriteLine("Los grados calsius son: " + Celsius);
                            break;
                        default:
                            System.Console.WriteLine("Operador Invalido");
                            break;
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