using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaperfiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int sumadora = 0;

            Console.WriteLine("ingrese la cantidad de piezas a procesar:");
            int piezas = int.Parse(Console.ReadLine());

            while(contadora <= piezas)
            {
                Console.WriteLine("ingrese el largo de la pieza:");
                float largo = float.Parse(Console.ReadLine());

                
                if(largo >= 1.20 && largo <= 1.30)
                {
                    sumadora = sumadora + 1;
                }

                contadora = contadora + 1;
            }

            Console.WriteLine("La cantidad total de piezas analizadas son: " + piezas);
            Console.WriteLine("La cantidad de piezas utilizables son: " + sumadora);
            Console.ReadKey();
        }
    }
}
