using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de dia: ");
            int dia= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("Feliz navidad!!!");
            }
            else
            {
                Console.WriteLine("Hoy no es navidad");
            }
            Console.ReadKey();

        }
    }
}
