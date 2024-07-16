using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays25_04
{
    internal class Program
    {
        private float[] alturas = new float[5];
        private float alturaPromedio = 0;
        
        private float altos = 0;

        public float cargarAlturas()
        {
            Console.WriteLine("ingrese las alturas");
            for(int i =0; i< alturas.Length; i++)
            {
                alturas[i]=float.Parse(Console.ReadLine());
                altos= altos + alturas[i];
            }

            return altos;
        }

        public void imprimirAlturas()
        {
            Console.WriteLine("las alturas son: ");
            for (int j = 0; j < alturas.Length; j++)
            {
                Console.WriteLine(alturas[j]);
                 

            }
            Console.ReadLine();
        }

        public float calculosAlturas()
        {
           
            alturaPromedio = altos / 5;
            return alturaPromedio;
        }

        static void Main(string[] args)
        {
            Program calculoDeAlturas = new Program();
            calculoDeAlturas.cargarAlturas();
            calculoDeAlturas.imprimirAlturas();
            calculoDeAlturas.calculosAlturas();
            Console.WriteLine("la altura promedio es: " + calculoDeAlturas.calculosAlturas());
            Console.ReadKey();

        }



        /*int[] sueldos = new int[5];

        public void cargarSueldos()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el sueldo");
                sueldos[i] = int.Parse(Console.ReadLine());
            }

        }

        public void imprimirSueldos()
        {
            Console.WriteLine("listado de sueldos");

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(sueldos[j]);

            }
        }
        static void Main(string[] args)
        {
            Program programaSueldos = new Program();
            programaSueldos.cargarSueldos();
            programaSueldos.imprimirSueldos();
            Console.ReadKey();

           
        }*/


    }
}
