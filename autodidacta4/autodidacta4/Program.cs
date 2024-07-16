using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodidacta4
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese un numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el multiplo mayor");
            int mayor = int.Parse(Console.ReadLine());
            int[] multiplo = new int[mayor];

            for(int i =0; i < multiplo.Length + 1; i++)
            {
                Console.WriteLine(numero1 * i);
            }
            Console.ReadKey();
        }
    }
}
