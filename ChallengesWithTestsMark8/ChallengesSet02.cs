using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var string = "abcdefghijklmnopqrstuvwxyz"; 
            return string.contains(c); 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number%2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (number%2 == 1);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers.Max + numbers.Min);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers.Where(x => x%2==0).Sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers.Sum % 2 == 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return Math.Floor(number/2);
        }
    }
}
