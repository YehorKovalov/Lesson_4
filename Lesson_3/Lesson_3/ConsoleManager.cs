using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public static class ConsoleManager
    {
        private const int ArrayMaxSize = 0X7FEFFFFF;
        private static readonly Predicate<int> IsArraySizeCorrect
            = new (size => (size > 0) && (size <= ArrayMaxSize));
        public static void SecuredArraySizeInput(ref int arrSize)
        {
            Console.WriteLine("Write a size of the array");
            do
            {
                int.TryParse(Console.ReadLine(), out arrSize);
                if (IsArraySizeCorrect(arrSize) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Size is supposed to be more than 0 and less than " + ArrayMaxSize);
                }
            }
            while (true);
        }

        public static void LogArray(params Array[] arrays)
        {
            foreach (var arr in arrays)
            {
                foreach (var el in arr)
                {
                    Console.Write(el + " ");
                }

                Console.WriteLine();
                Console.WriteLine(new string(string.Empty).PadLeft(arr.Length * 2, '-'));
            }

            Console.WriteLine();
        }
    }
}
