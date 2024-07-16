using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaiguales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer valor");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer valor");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 == num2 && num2 == num3 && num3 == num1)
            {
                int operacion= (num1 + num2) * num3;
                Console.WriteLine("El resultado es: " + operacion);
            }
            else
            {
                Console.WriteLine("Los numeros ingresados no son iguales");
            }
            Console.ReadKey();

        }
    }
}
