using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ingrese la medida de un lado del cuadrado");
            int lado = int.Parse(Console.ReadLine());
            int perimetro = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es de: " + perimetro + " mts.");
            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el primer numero");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            float num4 = float.Parse(Console.ReadLine());

            float suma = num1 + num2;
            float multi = num3 * num4;

            Console.WriteLine("El resultado de la suma es de: " + suma);
            Console.WriteLine("El resultado de la multiplicacion es de: " + multi);

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el primer numero");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            float num3 = float.Parse(Console.ReadLine());

            float suma= num1+num2+num3;
            Console.WriteLine("El promedio es de: " + suma/3);

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el precio del producto");
            float precioPorUnidad = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad a llevar");
            float cantidad = float.Parse(Console.ReadLine());

            Console.WriteLine("El total a pagar por el cliente es de: " + precioPorUnidad * cantidad);
            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el primer numero");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            float num2 = float.Parse(Console.ReadLine());

            if (num2 > num1)
            {
                Console.WriteLine("El segundo numero es mayor que el primero"); 
            }

            else 
            {
                Console.WriteLine("El primer numero es mayor que el segundo");
            }

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el primer numero");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            float num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor que el segundo");
                Console.WriteLine("suma: " + (num1 + num2));
                Console.WriteLine("resta:" + (num1 - num2));
            }

            else
            {
                Console.WriteLine("El segundo numero es mayor quer el primero");
                Console.WriteLine("multiplicacion: " + (num1 * num2));
                Console.WriteLine("division: " + (num1 / num2));

            }

            Console.ReadKey();*/


            /*Console.WriteLine("Ingrese la primer nota");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota");
            float nota3 = float.Parse(Console.ReadLine());

            float promedio = (nota1 + nota2 + nota3) / 3;


            if (promedio > 6.99)
            {
                Console.WriteLine("PROMOCIONADO");
               
            }
            else
            {
                Console.WriteLine("BURRO");
            }

            

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el numero a evaluar");
            float num = float.Parse(Console.ReadLine());
             
            
            if (num <= 9)
            {
                Console.WriteLine("El numero: " + num + " es de una cifra");


            }
            else
            {
                Console.WriteLine("El numero: " + num + " es de dos cifras");
            }

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese la primer nota");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota");
            float nota3 = float.Parse(Console.ReadLine());

            


            if (nota1 > nota2 & nota1 > nota3)
            {
                Console.WriteLine("Mejor calificacion: " + nota1);

            }
            else
            {
                if (nota2 > nota1 & nota2 > nota3)
                {
                    Console.WriteLine("Mejora calificacion: " + nota2);
                }
                else
                {
                    Console.WriteLine("Mejor calificacion: " + nota3);
                }
            }



            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el valor");
            float num = float.Parse(Console.ReadLine());
           




            if (num > 999)
            {
                Console.WriteLine("numero incorrecto");

            }
            else
            {
                if (num < 100 & num > 9)
                {
                    Console.WriteLine("es un numero de 2 cifras");
                }
                else 
                {
                    if (num > 99 & num < 1000)
                    {
                        Console.WriteLine("es un numero de 3 cifras");
                    }
                    else
                    {
                        Console.WriteLine("es un numero de una cifra");
                    }
                }

                                    
                
            }

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese la cantidad de preguntas");
            float preguntas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de respuestas acertadas");
            float respuestas = float.Parse(Console.ReadLine());

            float porcentaje = (preguntas * respuestas)/ 100;

            if ( porcentaje >= 90)
            {
                Console.WriteLine("Nivel maximo");

            }
            else
            {
                if (porcentaje < 90 && porcentaje >= 75)
                {
                    Console.WriteLine("Nivel medio");
                }
                else
                {
                    if (porcentaje < 75 && porcentaje >= 50)
                    {
                        Console.WriteLine("Nivel regular");
                    }
                    else
                    {
                        Console.WriteLine("Fuera de nivel");
                    }
                }



            }

            Console.ReadKey();*/

            /*Console.WriteLine("Ingrese el dia");
            float dia = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            float mes = float.Parse(Console.ReadLine());

            

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("Hoy es navidad");

            }
            else
            {
                Console.WriteLine("Hoy no es navidad");

            }

            Console.ReadKey();*/

            /*int num = 1;
            

            while (num > 0 && num < 101)
            {
                Console.WriteLine(num++);

            }

            Console.ReadKey();*/



            string[,] tablero2D = new string[,]
          {
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
          };




            Console.WriteLine("Ingrese el numero de jugador 1/2");
            string jugador = Console.ReadLine();

            Console.WriteLine("Ingrese la posicion de la ficha del 1 al 9");
            string ingreso = Console.ReadLine();

            string ficha;

            while (jugador == "1")
            {
                switch (ingreso)
                {
                    case 1: tablero2D[0, 0] = "X";
                    case "2": tablero2D[1, 1] = "X";
                    case "3": tablero2D[1, 2] = "X";
                    case "4":
                        tablero2D[]
                        tablero2D[2, 1] = ingreso;
                        tablero2D[2, 2] = ingreso;
                        tablero2D[2, 3] = ingreso;
                        tablero2D[3, 1] = ingreso;
                        tablero2D[3, 2] = ingreso;
                        tablero2D[3, 3] = ingreso;

                        break;
                }

                
                
            }
            
            }
            Console.ReadKey();
        }
    }
}
