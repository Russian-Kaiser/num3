using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поликлиника
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuteAdmissionTime = 10;
            int minutuesInHour = 60;

            Console.Write("Вы заходите в коридор, сколько человек вы увидели? - ");
            int queueLength = Convert.ToInt32(Console.ReadLine());
            int timeOfWaiting = minuteAdmissionTime * queueLength;
            int hoursOfWaiting = timeOfWaiting / minutuesInHour;
            int minutesOfWaiting = timeOfWaiting % minutuesInHour;
            Console.WriteLine($"Время ожидания: {hoursOfWaiting} час и {minutesOfWaiting} минут");
            Console.ReadKey();
        }
    }
}
