using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedioalumno1
{
    internal class PromediosAlumnos
    {
        private float nota1, nota2, nota3;
        private float promedio;

        public void CargarNotas()
        {
            Console.WriteLine("Ingrese la primer nota: ");
            nota1= float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercer nota: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;


        }

        public void MostrarResultados()
        {
            if (promedio>= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (promedio>= 4 && promedio < 7)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }

            }
        }
        static void Main(string[] args)
        {
            PromediosAlumnos promediosAlumnos= new PromediosAlumnos();
            promediosAlumnos.CargarNotas();
            promediosAlumnos.MostrarResultados();
            Console.ReadLine();


        }
    }
}
