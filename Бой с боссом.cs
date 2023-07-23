using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бой_с_боссом
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isActivatedMagicProtection = false;
            const int MagicCostBallLightning = 10;
            const int CostMagicProtection = 15;
            const int DeathBladeMagicCost = 5;
            const int DeathBladeStrike = 8;
            const int CriticalHealth = 15;
            const int BallLightning = 12;
            bool isEnemyStunned = false;
            const int EnemyDamage = 10;
            const int HealthRecovery = 8;
            const int MagicRecovery = 5;
            const int LastBreath = 15;
            int amountOfMagic = 10;
            string userInput = "";
            int enemyHealth = 70;
            int heroHealth = 50;

            Console.WriteLine("После долгого странствия, вы наконец нашли заклятого врага и готовы вступить с ним в последний бой..");
            Console.ReadKey();

            while (heroHealth > 0 & enemyHealth > 0)
            {

                Console.Clear();
                Console.WriteLine("Характеристики врага:");
                Console.WriteLine($"Здоровье: {enemyHealth}");
                Console.WriteLine($"Сила удара: {EnemyDamage}");
                Console.WriteLine("\nХарактеристики вашего персонажа:");
                Console.WriteLine($"Здоровье: {heroHealth}");
                Console.WriteLine($"Количество магии: {amountOfMagic}");
                Console.WriteLine("=================================");
                Console.WriteLine("Способности:");
                Console.WriteLine($"1. Удар клинком смерти: [-{DeathBladeStrike} здоровья. -{DeathBladeMagicCost} магии]");
                Console.WriteLine($"2. Удар световой молнией: [-{BallLightning} здоровья. -{MagicCostBallLightning} магии]");
                Console.WriteLine($"3. Магический щит: [-{CostMagicProtection} магии]");
                Console.WriteLine($"4. Последний вздох: [-{LastBreath} здоровья]");
                Console.WriteLine($"5. Пропустить удар: [+{MagicRecovery} магии. -{EnemyDamage} здоровья]");
                Console.Write("Введите номер заклинания: ");
                userInput = Console.ReadLine();

                if (userInput == "1" & amountOfMagic >= DeathBladeMagicCost)
                {
                    Console.WriteLine("Вы наносите внезапный удар клинком..");
                    amountOfMagic -= DeathBladeMagicCost;
                    enemyHealth -= DeathBladeStrike;
                }

                else if(userInput == "2" & amountOfMagic >= MagicCostBallLightning)
                {
                    Console.WriteLine("Вы призываете шаровую молнию, ранив и оглушив врага..");
                    amountOfMagic -= MagicCostBallLightning;
                    enemyHealth -= BallLightning;
                    isEnemyStunned = true;
                }

                else if(userInput == "3" & amountOfMagic >= CostMagicProtection)
                {
                    amountOfMagic -= CostMagicProtection;
                    isActivatedMagicProtection = true;
                }

                else if (userInput == "5")
                {
                    amountOfMagic += MagicRecovery;
                    heroHealth -= EnemyDamage;
                    continue;
                }

                else if (userInput == "4" & heroHealth <= CriticalHealth)
                {
                    enemyHealth -= LastBreath;
                }

                else if (userInput == "4" & heroHealth >= CriticalHealth)
                {
                    Console.WriteLine("Вы всё еще чувствуете себя бодрым.. Попробуйте другую способность");
                    heroHealth += EnemyDamage;
                    amountOfMagic -= MagicRecovery;
                }

                else
                {
                    Console.WriteLine("Что вы стоите? Действуйте!!");
                    Console.ReadKey();
                    continue;
                }

                if(isActivatedMagicProtection)
                {
                    isActivatedMagicProtection = false;
                    heroHealth += HealthRecovery;
                    amountOfMagic -= MagicRecovery;
                    continue;
                }

                if(isEnemyStunned)
                {
                    amountOfMagic += MagicRecovery;
                    isEnemyStunned = false;
                    Console.ReadKey();
                    continue;
                }

                heroHealth -= EnemyDamage;
                amountOfMagic += MagicRecovery;
                Console.ReadKey();
            }

            Console.Clear();

            if (heroHealth <= 0)
                Console.WriteLine("Вы погибли.");

            else if (heroHealth <= 0 & enemyHealth <= 0)
                Console.WriteLine("В долгой борьбе с врагом, вы пали в месте с ним.");

            else if (enemyHealth <= 0)
                Console.WriteLine("Вы победили!");

            Console.ReadKey();
        }
    }
}
