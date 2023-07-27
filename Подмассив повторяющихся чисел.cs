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
            int number = 0;
            int numberOfRepetitions = 0;
            int minimumNumber = 0;
            int maximumNumber = 11;
            int amountOfValues = 30;
            Random random = new Random();
            int[] numbers = new int[amountOfValues];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minimumNumber, maximumNumber);
                Console.Write(numbers[i] + " ");
            }

            foreach (var value in numbers)
            {
                if (numbers.Where(x => x.Equals(value)).Count() > numberOfRepetitions)
                {
                    numberOfRepetitions = numbers.Where(x => x.Equals(value)).Count();
                    number = value;
                }
            }

            Console.WriteLine($"\nЧисло: {number}. \nКоличество повторений: {numberOfRepetitions}.");
            Console.ReadKey();

        }
    }
}
