using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileImparPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int pares = 0;
            int impares = 0;
            int numEntero;

            Console.WriteLine("Ingrese la cantidad de numeros a analizar");
            int cantidad=int.Parse(Console.ReadLine());

            while (contadora <= cantidad)
            {
                Console.WriteLine("Ingrese un numero entero");
                numEntero= int.Parse(Console.ReadLine());

                if(numEntero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                contadora++;
            }

            Console.WriteLine("Cantidad de impares" + impares);
            Console.WriteLine("Cantidad de pares" + pares);

            Console.ReadKey();  
        }
    }
}
