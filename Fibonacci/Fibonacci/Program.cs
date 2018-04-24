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

        // Algorithm: n + (n - 1)
        static int Fibonacci(int n)
        {
            //base case
            if(n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
