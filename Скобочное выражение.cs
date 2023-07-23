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
            Console.Write("Введите выражение из символов '(' и ')' - ");
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                    counter++;

                else if (line[i] == ')')
                {
                    if (i < line.Length)
                    {
                        i++;

                        if (line[i - 1] != '(')
                            nestingDepth++;

                        i--;
                    }
                    counter--;
                }

                if (counter < 0)
                    break;
            }

            if (counter == 0)
                Console.Write($"Выражение корректно! \nМаксимальная глубина {nestingDepth - 1}");

            else
                Console.Write("Выражение некорректно!");

            Console.ReadKey();
        }
    }
}
