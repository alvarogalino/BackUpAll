using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calific = new int[] { 8, 7, 9, 3, 10, 5, 4, 7 };
            double promedioResultado = ObtenerPromedio(calific);

            foreach (int i in calific)
            {
                Console.WriteLine("{0}" , i);
            }
            Console.WriteLine("el promedio es {0}", promedioResultado);
            Console.Read();
        }

        static double ObtenerPromedio ( int[] arrayNotas)
        {
            int cantidad = arrayNotas.Length;
            double promedio = 0;
            int suma = 0;

            for (int i= 0; i< cantidad; i++)
            {
                suma += arrayNotas[i];
            }

            promedio = (double) suma / cantidad;

            return promedio;

        }
    }
}
