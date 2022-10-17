using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StopWatchProblem
    {
        public static void Stopwatch()
        {
            Console.WriteLine("Press Enter To Start The Watch");
            Console.ReadLine();
            Console.WriteLine("Time started");
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter To Stop The Watch");
            Console.ReadLine();
            Console.WriteLine("Time stopped");
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time is =" + (Stop - Start));

        }
    }
}
