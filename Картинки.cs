using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPictures = 52;
            int remainingPictures;
            int sizeRow = 3;
            int filledRows;

            filledRows = countPictures / sizeRow;
            remainingPictures = countPictures - (sizeRow * filledRows);
            Console.WriteLine($"Заполненных рядов {filledRows}.\nОсталось картинок {remainingPictures}.");
            Console.ReadKey();
        }
    }
}
