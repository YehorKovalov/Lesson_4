using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public static class ByteExtenstion
    {
        private const int NumberOfASCIISymbolsBeforeEnglishAlphabet = 96;
        private static readonly Predicate<int> IsOdd = new (value => (value & 1) == 1);
        public static void CopyEveryOddValuesTo(this byte[] fromArr, ref byte[] arr)
        {
            int newSizeCounter = 0;

            // fromArr.Where(el => (el & 1) == 1).ToArray().CopyTo(arr, 0);
            for (int i = 0; i < fromArr.Length; i++)
            {
                if (IsOdd(fromArr[i]) == true)
                {
                    arr.SetValue(fromArr[i], newSizeCounter++);
                }
            }

            Array.Resize(ref arr, newSizeCounter);
        }

        public static void CopyEveryEvenValuesTo(this byte[] fromArr, ref byte[] arr)
        {
            int newSizeCounter = 0;

            // fromArr.Where(el => (el & 1) == 0).ToArray().CopyTo(arr, 0);
            for (int i = 0; i < fromArr.Length; i++)
            {
                if (IsOdd(fromArr[i]) == false)
                {
                    arr.SetValue(fromArr[i], newSizeCounter++);
                }
            }

            Array.Resize(ref arr, newSizeCounter);
        }

        public static string GetAlphabetRepresentationString(this byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += NumberOfASCIISymbolsBeforeEnglishAlphabet;
            }

            return ASCIIEncoding.ASCII.GetString(array);
        }
    }
}
