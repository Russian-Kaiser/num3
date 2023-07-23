using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освоение_циклов
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение:");
            string userInput = Console.ReadLine();
            Console.Write("Введите число повторений:");
            int numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.WriteLine(userInput);
            }

            Console.ReadKey();
        }
    }
}
