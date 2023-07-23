using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_имени
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите символ:");
            char symbol = Convert.ToChar(Console.ReadLine());
            name = symbol + name + symbol;
            string symbolsLine = "";

            for (int i = 0; i < name.Length; i++)
            {
                symbolsLine += symbol;
            }

            Console.WriteLine("\n" + symbolsLine);
            Console.WriteLine(name);
            Console.WriteLine(symbolsLine);
            Console.ReadKey();
        }
    }
}
