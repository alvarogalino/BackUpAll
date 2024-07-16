using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodidacta5
{
    internal class Program
    {
        public void IngresarDatos()
        {
            int forma1;
            do
            { 
                Console.WriteLine("Ingrese la forma geometrica: 1-Rectangulo 2-Circulo 3-Triangulo 4-salir");
                forma1 = int.Parse(Console.ReadLine());

                switch (forma1)
                {
                    case 1:
                        Console.WriteLine("Ingrese la medida de la base en centimetros");
                        float base1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la medida de la altura");
                        float altura1 = float.Parse(Console.ReadLine());
                        float area1 = base1 * altura1;
                        Console.WriteLine("El area del rectangulo es: " + area1);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la medida del radio");
                        float radio1 = float.Parse(Console.ReadLine());
                        float area2 = (float)3.14 * (radio1 * radio1);
                        Console.WriteLine("El area del circulo es de: " + area2);
                        break;


                    case 3:
                        Console.WriteLine("Ingrese la medida de la primera base en centimetros");
                        float base3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la medida de la segunda base en centimetros");
                        float base4 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la medida de la altura");
                        float altura3 = float.Parse(Console.ReadLine());
                        float area3 = (base3 + base4 * altura3) / 2;
                        Console.WriteLine("El area del rectangulo es: " + area3);
                        break;

                    default:
                        Console.WriteLine("Opcion ingresada incorrecta");
                        Console.WriteLine("Vuelva a Ingresar una opcion");
                        break;
                }
            }while(forma1 !=1 && forma1!=2 && forma1 != 3);
        
        }
        static void Main(string[] args)
        {
            Program formasGeometricas= new Program();
            formasGeometricas.IngresarDatos();
            Console.ReadKey();
        }
    }
}
