using System;
using System.Linq;

namespace Lesson_3
{
    public class Program
    {
        public static void ToUpperCaseSpecificLetters(string result, string letters)
        {
            int curCharIndex = 0;
            var resultCharArray = result.ToCharArray();
            foreach (var letter in letters)
            {
                if (result.Contains(letter))
                {
                    while (true)
                    {
                        curCharIndex = result.IndexOf(letter, curCharIndex);
                        if (curCharIndex == -1)
                        {
                            break;
                        }

                        resultCharArray[curCharIndex] = char.ToUpper(result[curCharIndex++]);
                    }
                }

                curCharIndex = 0;
            }

            ConsoleManager.LogArray(resultCharArray);
        }

        public static void Main(string[] args)
        {
            int arrSize = 0;
            byte[] mainArr, evenValuesArr, oddValuesArr;
            ConsoleManager.SecuredArraySizeInput(ref arrSize);
            mainArr = new byte[arrSize];
            RandomValues.SeedArray(ref mainArr);
            evenValuesArr = new byte[arrSize];
            oddValuesArr = new byte[arrSize];
            mainArr.CopyEveryOddValuesTo(ref oddValuesArr);
            mainArr.CopyEveryEvenValuesTo(ref evenValuesArr);

            ConsoleManager.LogArray(mainArr, oddValuesArr, evenValuesArr);
            string oddValAlphRespres = oddValuesArr.GetAlphabetRepresentationString();
            string evenValAlphRespres = evenValuesArr.GetAlphabetRepresentationString();

            ToUpperCaseSpecificLetters(oddValAlphRespres, "aeidhj");
            ToUpperCaseSpecificLetters(evenValAlphRespres, "aeidhj");
        }
    }
}