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
            int counter = 0;
            int nestingDepth = 0;
            int currentDepth = 0;
            char start = '(';
            char end = ')';
            Console.Write("Введите выражение из символов '(' и ')' - ");
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                currentDepth = i;

                if (line[i] == start)
                {
                    counter++;
                }
                else if (line[i] == end)
                {
                    if (i < line.Length)
                    {
                        currentDepth++;

                        if (line[currentDepth - 1] != start)
                        {
                            nestingDepth++;
                        }
                           
                        currentDepth--;
                    }
                    counter--;
                }

                if (counter < 0)
                {
                    break;
                }
            }

            nestingDepth = nestingDepth - 1;

            if (counter == 0)
                Console.Write($"Выражение корректно! \nМаксимальная глубина {nestingDepth}");
            else
                Console.Write("Выражение некорректно!");

            Console.ReadKey();
        }
    }
}
