using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Степени_двойки
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(2, 900);
            int maxDegree = 11;
            int newNumber = 0;
            int number = 2;
            int degree = 0;

            for (int i = 0; i < maxDegree; i++)
            {
                degree = i;
                newNumber = Convert.ToInt32(Math.Pow(number, degree));

                if (newNumber >= randomNumber)
                    break;
            }

            Console.WriteLine($"Рандомное число: {randomNumber}");
            Console.WriteLine($"Полученное число - {newNumber}. Начальное число {number} в степени {degree}");
            Console.ReadKey();
        }
    }
}
