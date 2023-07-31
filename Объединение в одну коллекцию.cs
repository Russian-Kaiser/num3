using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Объединение_в_одну_коллекцию
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mergedCollection = new List<string>();
            string[] firstArry = {"1","2","1"};
            string[] secondArray = {"3","2"};

            AddToTheList(mergedCollection, firstArry);
            AddToTheList(mergedCollection, secondArray);
            Console.Write("Объединённый массив: ");

            foreach (var elements in mergedCollection)
            {
                Console.Write(elements + " ");
            }

            Console.ReadKey();
        }

        static void AddToTheList(List<string> mergedCollection, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(!mergedCollection.Contains(array[i]))
                {
                    mergedCollection.Add(array[i]);
                }
            }
        }
    }
}
