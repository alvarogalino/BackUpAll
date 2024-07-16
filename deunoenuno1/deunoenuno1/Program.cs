using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deunoenuno1
{
    internal class UnoEnUno
    {
        private int valorMaximo;
        private int ingreso = 1;

        public void CargarNumeros()
        {
            

            Console.WriteLine("Ingrese el valor maximo: ");
            valorMaximo = int.Parse(Console.ReadLine());

            Console.WriteLine(ingreso);

            while (ingreso < valorMaximo)
            {
                ingreso = ingreso + 1;
                Console.WriteLine(ingreso);

            }

        }
        static void Main(string[] args)
        {
            UnoEnUno sumaDeaUno= new UnoEnUno();
            sumaDeaUno.CargarNumeros();
            Console.ReadKey();
        }
    }
}
