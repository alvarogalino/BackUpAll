using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menoresadiez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            
            Console.WriteLine("Ingrese la cantidad de numeros a ingresar:");
            int cantidad =int.Parse(Console.ReadLine());
            nums= new int[cantidad];

            for(int i =0;i<nums.Length;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                nums[i] = int.Parse(Console.ReadLine());
               
                                
                
            }
            int evaluacion = 10;
            var check = Array.Exists(nums, x => x == evaluacion);

            if (check == true)
            {
                Console.WriteLine("Hay elementos mayores a 10");
            }
            else
            {
                
                Console.WriteLine("Todos los elemnetos son menores a 10");
            }
            Console.ReadKey();






        }

        
    }
}
