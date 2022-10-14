using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class reversenumber {

        public static void reverse1()
        {
            Console.WriteLine("Enter Any Positive Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int revnum = 0;
            while (num > 0)
            {
                temp = num % 10;
                num = num / 10;
                revnum = revnum*10+temp;
            }

            Console.WriteLine(revnum);
}


     }

}
