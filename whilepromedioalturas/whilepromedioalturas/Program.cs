using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilepromedioalturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int cantidad;
            float altura;
            float suma = 0;
            float promedio;

            Console.WriteLine("Ingrese la cantidad de alturas a medir: ");
            cantidad=int.Parse(Console.ReadLine());

            while (x <= cantidad)
            {
                Console.WriteLine("Ingrese una altura");
                altura=float.Parse(Console.ReadLine());

                suma=suma+altura;
                x = x + 1;
            }
            promedio= suma/cantidad;
            Console.WriteLine("La altura promedio es de: " + promedio);
            Console.ReadKey();  
        }
    }
}
