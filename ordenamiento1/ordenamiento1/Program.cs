using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento1
{
    internal class OrdenamientoVectores
    {
        private int[] vec;

        public void CargarVectores()
        {
            int vectoresCargados;
            Console.WriteLine("Ingrese la cantidad de vectores:");
            vectoresCargados=int.Parse(Console.ReadLine());
            vec= new int[vectoresCargados];

            for (int f = 0; f <=vec.Length-1; f++)
            {
                Console.WriteLine("Ingrese un numero entero: ");
                vec[f]= int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarVectores()
        {
            for(int k =0; k < vec.Length -1; k++)
            {
                for (int f=0; f < vec.Length -1; f++)
                {
                    if (vec[f] > vec[f + 1])
                    {
                        int aux = vec[f];
                        vec[f] = vec[f + 1];
                        vec[f + 1] = aux;
                    }
                    
                }
            }
        }

        public void ImprimirVectores()
        {
            Console.WriteLine("Los vectores ingresados son: ");
            for (int f=0; f < vec.Length; f++)
            {
                Console.WriteLine(vec[f]);
            }
        }
        static void Main(string[] args)
        {
            OrdenamientoVectores ordenamiento= new OrdenamientoVectores();
            ordenamiento.CargarVectores();
            ordenamiento.OrdenarVectores();
            ordenamiento.ImprimirVectores();
            Console.ReadKey();
        }
    }
}
