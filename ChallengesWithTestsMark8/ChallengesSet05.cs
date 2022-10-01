using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while ((startNumber+1)%n != 0)
            {
                startNumber++;
            }
            return startNumber+1;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED"; 
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false; 
            else 
            { 
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false; 
                }
            }
            }
            return true; 
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            else return numbers.Where((x,i)=> (i != 0 && numbers[i-1] % 2 == 0)).Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {   if (words == null) return "";
            var i = 0; 
            foreach(string word in words)
            {
                words[i] = word.Replace(" ", "");
                i++; 
            }
            var filteredWords = words.Where(x => !string.IsNullOrWhiteSpace(x)); 
            if (filteredWords.ToArray().Length == 0) return ""; 
            var sentence = String.Join(" ", filteredWords);
            return $"{sentence}."; 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) return new double[0];
            else return elements.Where((x,i) => (i+1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(var i = 0; i < nums.Length; i++)
            {
                for(var j=i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true; 
                    } 
                }
            }


            return false; 
        }
    }
}
