using System;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                if(number % 2 == 0) { sum += number; }
                else { sum -= number; }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var minimum = new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
            return minimum; 
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var minimum = new[] {number1,number2,number3,number4}.Min();
            return minimum; 
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name= "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // check if any two sides sum is greater than the other side. 
            return (sideLength1+sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = objs.Count(e => e == null);
            return nullCount > objs.Length / 2; 
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            var cache = numbers.Where(x => x % 2 == 0); 
            if(cache.ToArray().Length == 0)
            {
                return 0;
            } else return cache.Average(); 
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("number");
            else { 
            try { 
            var output = 1; 
            for(var i = 1; i <= number; i++)
            {
                output = output * i;
            }
            return output;
            }
            catch(Exception ex) {Console.WriteLine(ex.Message); return 0;}}
        }
    }
}
