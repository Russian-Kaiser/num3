using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Кем вы работаете?");
            string work = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Здравствуйте, {name}. Вам {age} лет и вы работаете {work}.");
            Console.ReadKey();
        }
    }
}
