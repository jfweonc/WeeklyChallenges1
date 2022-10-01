using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {   // if false exists in array, it will return true; if not, it will return false
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {   
            if (numbers == null)
            {
                return false;
            }

            // count how many odd numbers
            var countOfOdd = numbers.Count(x => x % 2 != 0);
            // if the count of odd numbers is odd, then the sum is odd. 
            return countOfOdd%2 == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var ifUpper = 0;
            var ifLower = 0;
            var ifNumber = 0; 
            foreach (var character in password)
            {
                if (Char.IsUpper(character))
                {
                    ifUpper++;
                }
                if (Char.IsLower(character))
                {
                    ifLower++;
                }
                if (Char.IsNumber(character))
                {
                    ifNumber++;
                }
            }
            return ifUpper != 0 && ifLower != 0 && ifNumber != 0;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0]; 
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0) { return 0; }
            else return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            // declare variable output, initialize it with 1. 
            var output = 1;
            var outputArray = new int[50]; 
            var i = 0; 
            // print all odd numbers from 1 to 99. each time increment output by 2. 
            while(output < 100)
            {
                Console.WriteLine(output);
                outputArray[i] = output;
                i++; 
                output += 2; 
            }
            return outputArray; 
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;
            foreach (var word in words)
            {
                words[i] = word.ToUpper();
                i++; 
            }
        }
    }
}
