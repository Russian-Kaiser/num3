using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_меню
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandChangeUserName = "1";
            const string CommandSetPassword = "2";
            const string CommandLeaveANotes = "3";
            const string CommandViewNotes = "4";
            string userName = "Пользователь";
            const string CommandExit = "5";
            const int NumberOfAttempts = 3;
            bool isPasswordChanged = false;
            bool isPasswordTrue = true;
            bool isWork = true;
            string userInput = "";
            string password = "";
            string note = "";

            while (isWork)
            {
                if (isPasswordChanged == true)
                {
                    for (int i = 0; i < NumberOfAttempts; i++)
                    {
                        Console.Clear();
                        Console.Write($"Вам дано {NumberOfAttempts - i} попытки.\nВведите пароль: ");
                        userInput = Console.ReadLine();

                        if (password == userInput)
                        {
                            isPasswordChanged = false;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Неправильный пароль!");
                            Console.ReadKey();
                        }

                        if (i == (NumberOfAttempts - 1) & (password != userInput))
                        {
                            isPasswordTrue = false;
                            isWork = false;
                        }
                    }
                }

                if(isPasswordTrue)
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Приветствую, {userName}!");
                    Console.SetCursorPosition(40, 1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("##########################");
                    Console.SetCursorPosition(39, 2);
                    Console.WriteLine($"{CommandChangeUserName}. Изменить имя пользователя");
                    Console.SetCursorPosition(39, 3);
                    Console.WriteLine($"{CommandSetPassword}. Установить пароль");
                    Console.SetCursorPosition(39, 4);
                    Console.WriteLine($"{CommandLeaveANotes}. Оставить заметку");
                    Console.SetCursorPosition(39, 5);
                    Console.WriteLine($"{CommandViewNotes}. Посмотреть заметки");
                    Console.SetCursorPosition(39, 6);
                    Console.WriteLine($"{CommandExit}. Выйти из меню");
                    Console.SetCursorPosition(40, 7);
                    Console.WriteLine("##########################");
                    Console.SetCursorPosition(44, 8);
                    Console.Write("Введите номер: ");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case CommandChangeUserName:
                            Console.Clear();
                            Console.Write("Введите новое имя пользователя: ");
                            userName = Console.ReadLine();

                            if (userName.Contains(" ") | (userName.Contains("") & userName.Length == 0))
                                userName = "Пользователь";
                            break;
                        case CommandSetPassword:
                            Console.Clear();
                            Console.Write("Введите новый пароль: ");
                            password = Console.ReadLine();
                            isPasswordChanged = true;

                            if (password.Contains(" ") | (password.Contains("") & password.Length == 0))
                            {
                                isPasswordChanged = false;
                                password = "";
                            }
                            break;
                        case CommandLeaveANotes:
                            Console.Clear();
                            Console.Write("Введите новое сообщение:");
                            note += Console.ReadLine() + "\n";
                            break;
                        case CommandViewNotes:
                            Console.Clear();
                            Console.WriteLine(note);
                            Console.ReadKey();
                            break;
                        case CommandExit:
                            isWork = false;
                            break;
                    }
                }
            }
        }
    }
}
