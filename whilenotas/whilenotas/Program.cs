using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilenotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int sumadoraMayores = 0;
            int sumadoraMenores = 0;

            while (contadora <= 10)
            {
                Console.WriteLine("Ingrese una nota");
                int nota=int.Parse(Console.ReadLine());

                if (nota >=7)
                {
                    sumadoraMayores++;
                }
                else
                {
                    sumadoraMenores++;
                }

                contadora++;
            }

            Console.WriteLine("La cantidad de notas mayores es: " + sumadoraMayores);
            Console.WriteLine("La cantidad de notas menores es: " + sumadoraMenores);

            Console.ReadKey();  

        }
    }
}
