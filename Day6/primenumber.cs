using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class primenumber
    {
        public static void prime1()
        {   
            int Flag = 0;
            int i;
            Console.WriteLine("Please Enter Any  Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==1 || n == 0)
            {
                Flag = 1;
                    
            }
            for(i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                {
                    Flag = 1;
                    break;
                }
            }

            if (Flag == 1)
            {
                Console.WriteLine("number is not prime");
            }
            else
            {
                Console.WriteLine("number is prime");
            }
        }
    }
}
