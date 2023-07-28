using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подмассив_повторений_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumberOfRepetitions = 0;
            int numberOfRepetitions = 0;
            int amountOfValues = 30;
            int maximumNumber = 11;
            int minimumNumber = 0;
            int maxValue = 0;
            int value = 0;
            int[] numbers = new int[amountOfValues];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minimumNumber, maximumNumber);
                Console.Write(numbers[i] + " ");
            }

            for (int j = 1; j < numbers.Length; j++)
            {
                if (maxNumberOfRepetitions < numberOfRepetitions)
                {
                    maxValue = value;
                    maxNumberOfRepetitions = numberOfRepetitions;
                }

                if (numbers[j - 1] == numbers[j])
                {
                    value = numbers[j];
                    numberOfRepetitions++;
                }
                else
                {
                    numberOfRepetitions = 1;
                }
            }

            if (maxNumberOfRepetitions > 1)
                Console.WriteLine($"\nЧисло: {maxValue}. \nКоличество повторений: {maxNumberOfRepetitions}.");
            else
                Console.WriteLine("Нет повторяющихся чисел.");

            Console.ReadKey();
        }
    }
}
