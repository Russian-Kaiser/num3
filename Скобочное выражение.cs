using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Скобочное_выражение
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentDepth = 0;
            int maximumDepth = 0;
            char openBracket = '(';
            char closedBracket = ')';
            Console.Write($"Введите выражение из символов {openBracket} и {closedBracket} - ");
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == openBracket)
                {
                    currentDepth++;

                    if (currentDepth > maximumDepth)
                        maximumDepth++;
                }
                else if (line[i] == closedBracket)
                {
                    currentDepth--;
                }

                if (currentDepth < 0)
                    break;
            }

            if (currentDepth == 0)
                Console.Write($"Выражение корректно! \nМаксимальная глубина {maximumDepth}");
            else
                Console.Write("Выражение некорректно!");

            Console.ReadKey();
        }
    }
}
