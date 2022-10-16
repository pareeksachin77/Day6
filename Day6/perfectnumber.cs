using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class perfectnumber
    {
        public static void pn()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int i;
            for(i= 1; i < n; i++)
            {
                if(n%i== 0)
                {
                    x += i;
                }
            }

            
            if (n == x)
            {
                Console.WriteLine("number is perfoect number");
            }
            else
            {
                Console.WriteLine("number is not perfect number");
            }
        }
    }
}
