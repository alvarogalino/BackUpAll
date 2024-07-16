using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileacumulador25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadora = 1;
            int serie = 0;

            while(contadora <=25)
            {
                serie = serie + 11;
                Console.Write(serie);
                Console.Write(" - " );

                contadora++;
            }

            Console.ReadKey();
        }
    }
}
