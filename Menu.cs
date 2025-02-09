using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos_Programacion
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("1 = Operaciones Basicas");
            System.Console.WriteLine("2 = Calculo de Areas");
            System.Console.WriteLine("3 = Menu Raro");
            System.Console.WriteLine("Elija una Opcion");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Console.WriteLine("Operaciones Basicas");
                    System.Console.WriteLine("1 = SUMA");
                    System.Console.WriteLine("2 = RESTA");
                    System.Console.WriteLine("3 = MULYIPLICACION");
                    System.Console.WriteLine("4 = DIVISION");
                    System.Console.WriteLine("Elija una Opcion");
                    int opc = int.Parse(Console.ReadLine());
                    switch (opc)
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
                    break;
                case 2:
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
                    break;
                case 3:
                    System.Console.WriteLine("Menu Raro");
                    System.Console.WriteLine("1 = Area de Cuadrado");
                    System.Console.WriteLine("2 = Promemdio");
                    System.Console.WriteLine("3 = Temperatura");
                    System.Console.WriteLine("4 = Densidad");
                    System.Console.WriteLine("5 = Masa");
                    System.Console.WriteLine("6 = Volumen");
                    System.Console.WriteLine("7 = Puntaje");
                    System.Console.WriteLine("Elige una opcion");
                    int opcio = int.Parse(Console.ReadLine());
                    switch (opcio)
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
                            int opcion = int.Parse(Console.ReadLine());
                            switch (opcion)
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
                            double ma = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese la Densidad");
                            double de = double.Parse(Console.ReadLine());
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
                    break;
                default:
                    System.Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
    }
}
