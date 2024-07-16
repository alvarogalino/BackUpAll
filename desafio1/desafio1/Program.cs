using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numeros = new int[] {5,10,15,20,25};

            for (int i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine("Los numeros originales son " + numeros[i]);

            }

            Console.Read();

            sumaValores(numeros);

            

            for (int i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine("los numeros mas 400 son: " + numeros[i]);

            }
            Console.ReadKey();

            

            



        }


        static void sumaValores(int[] numero2)
        {
            for (int i = 0; i < numero2.Length; i++)
            {
                numero2[i]+=400;           


            }

            
        }
    }
    
}
