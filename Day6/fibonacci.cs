using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6;

    public class fibonacci
    {
       public static int Fib(int n)
        {
            int []f = new int[n + 2];

            f[0] = 0;
            f[1] = 1;
            int i;
            for(i=2; i<=n; i++)
            {
                f[i]= f[i-1] + f[i-2];
                
            }
            return f[n];

        }
        public static void f2()
        {
            int n = 9;
            Console.WriteLine(Fib(n));
        }
    }

