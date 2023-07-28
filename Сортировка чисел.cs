using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int minimumNumber = 0;
            int maxsimumNumber = 100;
            Random random = new Random();
            int[] array = new int[arrayLength];
            int[] sortedArray = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minimumNumber,maxsimumNumber);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < sortedArray.Length; j++)
            {
                sortedArray[j] = array.Min();

                for (int t = 0; t < array.Length; t++)
                {
                    if (array[t] == sortedArray[j])
                        array[t] = 1000;
                }

                Console.Write(sortedArray[j] + " ");
            }

            Console.ReadKey();
        }
    }
}
