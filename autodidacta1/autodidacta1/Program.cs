using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodidacta1
{
    internal class Escuela
    {
        int[] cursoA = new int[5];
        int[] cursoB = new int[5];
        

        public void CargarNotas()
        {
            Console.WriteLine("Ingrese las notas del curso A");
            for(int i = 0;i < 5; i++)
            {
                cursoA[i] =  int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("Ingrese las notas del curso B");
            for (int j = 0; j < 5; j++)
            {
                cursoB[j] = int.Parse(Console.ReadLine());
            }

        }

        public void CalcularPromedio()
        {
            int suma1 = 0;
            int suma2 = 0;

            for(int k =0; k < 5;k++)
            {
                suma1= suma1 + cursoA[k];
                suma2 = suma2 + cursoB[k];
            }

            int promedio1 = suma1 / 5;
            int promedio2 = suma2 / 5;

            if(promedio1 > promedio2)
            {
                Console.WriteLine("El promedio mas alto es del curso A");

            }
            else
            {
                Console.WriteLine("El promedio mas alto es del curso B");

            }
            

        }

        static void Main(string[] args)
        {
            Escuela notasSemestre = new Escuela();
            notasSemestre.CargarNotas();
            notasSemestre.CalcularPromedio();
            Console.ReadLine();
            

        }
    }
}
