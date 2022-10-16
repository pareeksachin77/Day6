using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class fibonacci2
    {
        public static int fibonacci_numbers(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci_numbers(n - 2) + fibonacci_numbers(n - 1);
            }
        }
        public static void fibo()
        {
            Console.WriteLine("Enter Any Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                // Function call
                Console.Write(fibonacci_numbers(i) + " ");
            }
        }
    }
}
