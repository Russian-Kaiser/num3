using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Последовательность
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = 5;
            int endValue = 96;
            int step = 7;

            for (int i = startValue; i <= endValue; i += step)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
