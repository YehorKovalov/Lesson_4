using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public static class RandomValues
    {
        public static void SeedArray(ref byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)new Random().Next(1, 27);
            }
        }
    }
}
