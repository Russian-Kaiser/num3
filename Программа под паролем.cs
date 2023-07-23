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
            const int NumberOfAttempts = 3;
            const string Password = "A1BC3";
            string userInput = "";

            for (int i = 0; i < NumberOfAttempts; i++)
            {
                Console.Clear();
                Console.Write($"У вас есть {NumberOfAttempts - i} попытки. \nВведите пароль: ");
                userInput = Console.ReadLine();

                if(userInput == Password)
                {
                    Console.WriteLine("\nНачинается загрузка данных....");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("\nНеправильный пароль! \nПопробуйте снова");
                    Console.ReadKey();
                }
            }
        }
    }
}
