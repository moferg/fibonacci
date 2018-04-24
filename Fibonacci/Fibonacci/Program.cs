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
            // for loop i < 10
                // Fibonacci(i);
        }

        // Algorithm: n + (n - 1)
        static int Fibonacci(int n)
        {
            //base case
            if(n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n) + Fibonacci(n - 1);
        }
    }
}
