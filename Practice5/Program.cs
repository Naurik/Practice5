using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultOfFirstConversion, resultOfSecondConversion;
            int beginningOfRange, endOfRange;
            Random rnd = new Random();

            Console.Write("Введите начало диапазона: ");
            resultOfFirstConversion = int.TryParse(Console.ReadLine(), out beginningOfRange);
            Console.Write("Введите конец диапазона: ");
            resultOfSecondConversion = int.TryParse(Console.ReadLine(), out endOfRange);

            Console.WriteLine();

            if (resultOfFirstConversion && resultOfSecondConversion)
            {
                if (beginningOfRange > endOfRange) Swap(ref beginningOfRange, ref endOfRange);

                RangeOfArray arbitraryArray = new RangeOfArray(beginningOfRange, endOfRange);

                for (int i = arbitraryArray.BeginningOfRange; i <= arbitraryArray.EndOfRange; i++)
                {
                    arbitraryArray[i] = rnd.Next(10, 100);
                    Console.WriteLine("Массив[{0}]: {1}", i, arbitraryArray[i]);
                }
            }
        }

        static void Swap(ref int beginningOfRange, ref int endOfRange)
        {
            int temp = beginningOfRange;
            beginningOfRange = endOfRange;
            endOfRange = temp;
        }
    }
    }
}
