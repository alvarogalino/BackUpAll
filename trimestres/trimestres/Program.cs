using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trimestres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dia:");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese mes:");
            int mes= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese ano:");
            int year= int.Parse(Console.ReadLine());

            if (mes <13 && mes > 9)
            {
                Console.WriteLine("Estamos en el ultimo trimestre del ano");
            }
            else
            {
                if (mes <10 && mes > 6)
                {
                    Console.WriteLine("Estamos en el tercer trimestre del ano");
                }
                else
                {
                    if(mes < 7 && mes > 3)
                    {
                        Console.WriteLine("Estamos en el segundo trimestre del ano");
                    }
                    else
                    {
                        Console.WriteLine("Estamos en el primer trimestre del ano");
                    }
                }
            }

            switch (mes)
            {
                case 0:

                    Console.WriteLine("numero inresado incorrecto");
                    break;

                case 1:

                    
                    Console.WriteLine(dia + " Enero " + year);
                    break;

                case 2:


                    Console.WriteLine(dia + " Febrero " + year);
                    break;

                case 3:


                    Console.WriteLine(dia + " Marzo " + year);
                    break;

                case 4:


                    Console.WriteLine(dia + " Abril " + year);
                    break;

                case 5:


                    Console.WriteLine(dia + " Mayo " + year);
                    break;

                case 6:


                    Console.WriteLine(dia + " Junio " + year);
                    break;

                case 7:


                    Console.WriteLine(dia + " Julio " + year);
                    break;

                case 8:


                    Console.WriteLine(dia + " Agosto " + year);
                    break;

                case 9:


                    Console.WriteLine(dia + " Septiembre " + year);
                    break;

                case 10:


                    Console.WriteLine(dia + " Octubre " + year);

                    break;

                case 11:


                    Console.WriteLine(dia + " Noviembre " + year);

                    break;
                    

                case 12:


                    Console.WriteLine(dia + " Diciembre " + year);

                    break;

            }
            Console.ReadKey();
        }
    }
}
