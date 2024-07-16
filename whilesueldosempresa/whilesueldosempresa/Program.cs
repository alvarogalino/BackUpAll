using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilesueldosempresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int sumadoraMayores = 0;
            int sumadoraMenores = 0;
            int sumaSueldos = 0;
            int cantEmpleados;

            Console.WriteLine("Ingrese la cantidad de empleados:");
            cantEmpleados=int.Parse(Console.ReadLine());

            while(contadora <=cantEmpleados)
            {
                contadora++;
                Console.WriteLine("Ingrese el sueldo del empleado: ");
                int sueldo=int.Parse(Console.ReadLine());

                sumaSueldos = sumaSueldos + sueldo;

                if (sueldo <= 300)
                {
                    sumadoraMenores++;
                }
                else
                {
                    sumadoraMayores++;
                }
            }
            Console.WriteLine("El presupesto total en sueldos es de: " + sumaSueldos);
            Console.WriteLine("La cantidad de sueldos por debajo de 300 es de: " + sumadoraMenores);
            Console.WriteLine("La cantidad de sueldos por encima de 300 es de: " + sumadoraMayores);
            Console.ReadKey();


        }
    }
}
