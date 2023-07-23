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
            bool exit = true;

            while(exit)
            {
                Console.Clear();
                Console.Write("Введите 'exit', чтобы закончить цикл: ");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                    exit = false;

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
