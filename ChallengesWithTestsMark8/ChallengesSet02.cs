using System;
using System.Collections.Generic;
using System.Linq; 

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var string1 = "abcdefghijklmnopqrstuvwxyz";
            return string1.Contains(c.ToString().ToLower()); 
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
            return (num%2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.ToArray().Length == 0) { return 0; }
            return (numbers.Max() + numbers.Min());
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) { return 0; }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if( numbers == null || numbers.ToArray().Length == 0) { return 0; }
            return numbers.Where(x => x%2==0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers==null || numbers.ToArray().Length == 0) { return false; }
            return (numbers.Sum()) % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 1) { return 0; }
            return number / 2; 
        }
    }
}
