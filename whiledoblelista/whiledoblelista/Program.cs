using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledoblelista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int sumaLista1 = 0;
            int sumaLista2 = 0;

            while(contadora <=15)
            {
                Console.WriteLine("Ingrese el valor");
                int valor1 = int.Parse(Console.ReadLine());

                sumaLista1 = sumaLista1 + valor1;
                
                contadora++;
            }

            while(contadora > 15 && contadora<=30)
            {
                Console.WriteLine("Ingrese el valor");
                int valor2 = int.Parse(Console.ReadLine());

                sumaLista2 = sumaLista2 + valor2;

                contadora++;
            }
            if (sumaLista1> sumaLista2)
            {
                Console.WriteLine("La suma de la lista 1 es mayor");
                Console.WriteLine(sumaLista1);
            }
            else
            {
                Console.WriteLine("La suma de la lista 2 es mayor");
                Console.WriteLine(sumaLista2);
            }

            Console.ReadKey();

        }
    }
}
