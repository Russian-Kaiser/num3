using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертер_Валют
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandChangeRublesToDollars = "1", CommandChangeRublesToEuros = "2";
            const string CommandChangeDollarsToRubles = "3", CommandChangeDollarsToEuros = "4";
            const string CommandChangeEurosToRubles = "5", CommandChangeEurosToDollars = "6";
            const float DollarsToEuros = 0.62f, DollarsToRubles = 0.8f;
            const float RublesToDollars = 0.45f, RublesToEuros = 0.5f;
            const float EurosToDollars = 0.42f, EurosToRubles = 0.9f;
            const string Exit = "7";
            int userCurrency = 0;
            string userInput = "";
            bool isWork = true;

            Console.WriteLine("Добро пожаловать в наш банк!");
            Console.Write("Введите количество денег на рублёвом счёте: ");
            float rubleAccount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество денег на долларовом счёте: ");
            float dollarAccount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество денег на евро счёте: ");
            float euroAccount = Convert.ToSingle(Console.ReadLine());

            while(isWork)
            {
                Console.Clear();
                Console.WriteLine($"Счёт рублей: {rubleAccount}");
                Console.WriteLine($"Счёт долларов: {dollarAccount}");
                Console.WriteLine($"Счёт евро: {euroAccount}");
                Console.WriteLine($"\n{CommandChangeRublesToDollars}. Поменять рубли на доллары");
                Console.WriteLine($"{CommandChangeRublesToEuros}. Поменять рубли на евро");
                Console.WriteLine("================================");
                Console.WriteLine($"{CommandChangeDollarsToRubles}. Поменять доллары на рубли");
                Console.WriteLine($"{CommandChangeDollarsToEuros}. Поменять доллары на евро");
                Console.WriteLine("================================");
                Console.WriteLine($"{CommandChangeEurosToRubles}. Поменять евро на рубли");
                Console.WriteLine($"{CommandChangeEurosToDollars}. Поменять евро на доллары");
                Console.WriteLine($"{Exit}. Выход");
                Console.WriteLine("================================");
                Console.Write("Введите номер операции: ");
                userInput = Console.ReadLine();

                if(userInput != Exit)
                {
                    Console.Write("Введите, сколько валюты вы хотите обменять: ");
                    userCurrency = Convert.ToInt32(Console.ReadLine());
                }

                switch (userInput)
                {
                    case CommandChangeRublesToDollars:
                        if(rubleAccount >= userCurrency)
                        {
                            dollarAccount += userCurrency * RublesToDollars;
                            rubleAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case CommandChangeRublesToEuros:
                        if (rubleAccount >= userCurrency)
                        {
                            euroAccount += userCurrency * RublesToEuros;
                            rubleAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case CommandChangeDollarsToRubles:
                        if (dollarAccount >= userCurrency)
                        {
                            rubleAccount += userCurrency * DollarsToRubles;
                            dollarAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case CommandChangeDollarsToEuros:
                        if (dollarAccount >= userCurrency)
                        {
                            euroAccount += userCurrency * DollarsToEuros;
                            dollarAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case CommandChangeEurosToRubles:
                        if (euroAccount >= userCurrency)
                        {
                            rubleAccount += userCurrency * EurosToRubles;
                            euroAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case CommandChangeEurosToDollars:
                        if (euroAccount >= userCurrency)
                        {
                            dollarAccount += userCurrency * EurosToDollars;
                            euroAccount -= userCurrency;
                        }

                        else
                        {
                            Console.WriteLine("Недостаточное количество валюты.");
                            Console.ReadKey();
                        }
                        break;
                    case Exit:
                        isWork = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой операции нет.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
