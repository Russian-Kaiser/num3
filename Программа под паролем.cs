using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программа_под_паролем
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainingAttempts = 0;
            int numberOfAttempts = 3;
            string password = "A1BC3";
            string userInput = "";

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                remainingAttempts = numberOfAttempts - i;
                Console.Write($"У вас есть {remainingAttempts} попытки. \nВведите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                    Console.WriteLine("\nНачинается загрузка данных....");
                else
                    Console.WriteLine("\nНеправильный пароль! \nПопробуйте снова");

                Console.ReadKey();
            }
        }
    }
}
