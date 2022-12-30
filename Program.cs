using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num");
            int y = int.Parse(Console.ReadLine());

            for (int i = x + 1; i <= y; ++i)
            {
                bool is_prime = true;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }

                if (is_prime)
                {
                    Console.WriteLine("{0} is a prime number", i);
                }
                else
                    Console.WriteLine("{0} is a not prime number", i);
            }

            Console.ReadLine();





        }
    }
}
