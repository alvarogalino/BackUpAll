using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodidacta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 101; i++) 
            {
                Console.WriteLine(i);
                if(i % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    if (i % 5 ==0)
                    {
                        Console.WriteLine("Budd");
                    }
                    else 
                    { if (i % 3 ==0 && i % 5 ==0)
                        {
                            Console.WriteLine("FizzBudd");
                        }
                        else 
                        {
                            if(i % 7 == 0)
                            {
                               Console.WriteLine("Woff");
                            }
                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
