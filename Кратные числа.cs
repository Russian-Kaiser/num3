using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кратные_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 28);
            int maxValue = 999;
            int minValue = 100;
            int count = 0;

            for (int i = 0; i <= maxValue; i += randomNumber)
            {
                if (i >= minValue)
                    count++;
            }

            Console.WriteLine($"Рандомное число: {randomNumber} \nКоличество кратных трёхзначных чисел: {count}");
            Console.ReadKey();
        }
    }
}
