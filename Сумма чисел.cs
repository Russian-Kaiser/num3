using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secondDivisor = 5;
            int firstDivisor = 3;
            int minimumValue = 0;
            int endNumber = 0;
            int maxValue = 101;
            int sum = 0;

            endNumber = random.Next(minimumValue, maxValue);

            for (int i = 0; i <= endNumber; i++)
            {
                if(i % firstDivisor == 0 | i % secondDivisor == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
