using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desired output: 1 1 2 3 5 8 13 21 34 55
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Takes one number(n) and returns the Fibonacci sequence number of place n
        /// </summary>
        /// <param name="n">The place in the Fibonacci sequence ex. n = 5 returns 5th number in sequence</param>
        /// <returns>The Fibonacci sequence number in place n</returns>
        static int Fibonacci(int n)
        {
            // Base case
            if(n == 1 || n == 2)
            {
                return 1;
            }

            // Algorithm: (n - 1) + (n - 2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
