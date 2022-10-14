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
            int n = 100;
            int x = 0;
            int i;
            for(i= 1; i < n; i++)
            {
                if(n%i== 0)
                {
                    x += i;
                }
            }
            Console.WriteLine(x);
        }
    }
}
