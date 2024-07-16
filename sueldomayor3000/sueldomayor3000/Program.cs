using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldomayor3000
{
    internal class Sueldo3000
    {
        private int sueldo;
        public void CargarSueldo()
        {
            Console.WriteLine("Ingrese el sueldo de un empleado: ");
            sueldo = int.Parse(Console.ReadLine());

            if (sueldo > 3000) 
            {
                Console.WriteLine("El empleado debe pagar impuesto a las ganancias");
            }

        }
        static void Main(string[] args)
        {
            Sueldo3000 sueldoAlto= new Sueldo3000();
            sueldoAlto.CargarSueldo();
            Console.ReadLine();
        }
    }
}
