using System;

namespace Сдвиг_значений_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int tempValue = 0;

            Console.Write("Исходный массив: ");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\nВведите значение сдвига влево:");
            int shift = Convert.ToInt32(Console.ReadLine());

            for (int i = shift; i > 0; i--)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    tempValue = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tempValue;
                }
            }

            Console.Write("Изменённый массив: ");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
