using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(number => number % 2 == 0).Sum() - numbers.Where(number => number % 2 == 1).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
            return strings.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1+sideLength2>sideLength3 && sideLength3+sideLength1>sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            float number;
            return float.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullAmount = objs.Count(x => x == null);
            return nullAmount > objs.Count() / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Any(x => x % 2 == 0))
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int answer = 1;
            for(int i = 1; i <= number; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
