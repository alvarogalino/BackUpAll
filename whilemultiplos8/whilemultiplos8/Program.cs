using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilemultiplos8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int multiplo = 8;

            while (multiplo <= 500)
            {
                
                Console.Write(multiplo);
                Console.Write(" - ");
                multiplo = multiplo + 8;

            }

            Console.ReadKey();
        }
    }
}
