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
            int pricePerCrystal = 15;   

            Console.Write("Добро пожаловать в магазин кристаллов! \nСколько у вас имеется золота? - ");
            int amountOfGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nПрекрасно! Сегодня вы можете купить кристаллы по сниженной цене:");
            Console.WriteLine($"1 кристалл - {pricePerCrystal} золотых монет.");
            Console.Write("\nСколько вы хотите купить кристаллов? - ");
            int amountOfСrystals = Convert.ToInt32(Console.ReadLine());
            amountOfGold -= pricePerCrystal * amountOfСrystals;
            Console.WriteLine($"\nВы получаете {amountOfСrystals} кристаллов. \nУ вас остаётся {amountOfGold} золотых.");
            Console.WriteLine("Хорошего дня!");
            Console.ReadKey();
        }
    }
}
