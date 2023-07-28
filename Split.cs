using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = ' ';
            Console.Write("Введите текст:");
            string text = Console.ReadLine();
            string [] words = text.Split(separator);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
