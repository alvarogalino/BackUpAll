using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_220423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            irregular[0] = new int[] { 2, 3, 8, 9, 11};
            irregular[1] = new int[] { 23, 200, 25 };
            irregular[2] = new int[] { 5, 900 };

            // segunda forma

            int[][] irregular2 = new int[][]
            {
                new int[] { 2, 3, 8, 9, 11 },
                new int[] { 23, 100, 15 },
                new int[] { 5, 900 }
            };

            Console.WriteLine(irregular2[1][1]);
            Console.WriteLine(irregular[0][4]);

           

            for (int i = 0; i < irregular2.Length; i++)
            {
                Console.WriteLine("los valores del array{0} son:" , i);
                for(int j = 0; j < irregular[i].Length; j++)
                {
                    Console.WriteLine("{0}", irregular[i][j]);
                }
            }
            Console.ReadKey();



        }    
    }
}
