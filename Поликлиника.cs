using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ergrh
{
    class Program
    {
        static void Main(string[] args)
        {
            int receptionTimeInMinutes = 10;
            int hourInMinutes = 60;

            Console.WriteLine("Вы заходите в поликлинику и увидели очередь..");
            Console.Write("Сколько в ней было человек? - ");
            int queueLength = Convert.ToInt32(Console.ReadLine());
            int waitingHours = (receptionTimeInMinutes * queueLength) / hourInMinutes;
            int waitingMinutes = (queueLength * receptionTimeInMinutes) - (waitingHours * hourInMinutes);
            Console.WriteLine($"Вам предстоит ожидать {waitingHours} час и {waitingMinutes} минут");
            Console.ReadKey();
        }
    }
}
