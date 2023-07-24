using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контроль_выхода
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string password = "exit";
            bool isExit = true;

            while (isExit)
            {
                Console.Clear();
                Console.Write("Введите 'exit', чтобы закончить цикл: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    isExit = false;
                }
                else
                {
                    Console.WriteLine("Неправильное значение");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
