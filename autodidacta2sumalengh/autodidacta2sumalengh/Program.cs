using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodidacta2sumalengh
{
    internal class Sumatoria

    {
        int[] elementos; 
        

        public void CargarElementos()
        {
            Console.WriteLine("ingrese la cantidad de elementos a utilizar");
            int n= int.Parse(Console.ReadLine());
            elementos = new int[n];
            
        }

        public void SumarElementos()
        {
            int suma = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                
                Console.WriteLine("Ingrese el numero a sumar:");
                elementos[i] = int.Parse(Console.ReadLine());
                suma = suma+ elementos[i];
            }
            Console.WriteLine("El resultado es: " + suma);
        }
        
        

        
        static void Main(string[] args)
        {
            Sumatoria total = new Sumatoria();
            total.CargarElementos();
            total.SumarElementos();
            Console.ReadKey();
        }



    }



}
