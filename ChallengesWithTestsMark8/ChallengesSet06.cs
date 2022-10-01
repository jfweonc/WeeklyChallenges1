using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null) { return false; }
            if (ignoreCase)
            {
                return words.Contains(word, StringComparer.OrdinalIgnoreCase); 
            }   
            else 
            { 
                return words.Contains(word); 
            }
            
        }

        public bool IsPrimeNumber(int num)
        {
            if(num < 2)
            {
                return false; 
            }   else
            {
                var squareRt = Math.Floor(Math.Sqrt(num));
                for(int i = 2; i <= squareRt; i++)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
                return true; 
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Console.WriteLine(123456789); 
            var outputArray = str.Where(x => (str.Where(y => y==x)).Count() == 1).ToArray();
            if(outputArray.Length == 0)
            {
                return -1; 
            } else { 
            return str.IndexOf(outputArray[outputArray.Length - 1]);
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int maxCount = 1; 
            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                } else count = 1; 
                if (count > maxCount) { maxCount = count; }              
            }
            return maxCount; 
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n<=0 || elements is null || elements.Count <= 0)
            {
                return new double[0]; 
            } else return elements.Where((x,i) => (i+1)%n==0).ToArray();
        }
    }
}
