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
            int tempNumber = 0;
            int arrayLength = 10;
            int minimumNumber = 0;
            int maxsimumNumber = 100;
            Random random = new Random();
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minimumNumber, maxsimumNumber);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if(array[j] > array[k])
                    {
                        tempNumber = array[j];
                        array[j] = array[k];
                        array[k] = tempNumber;
                    }
                }

                Console.Write(array[j] + " ");
            }

            Console.ReadKey();
        }
    }
}
