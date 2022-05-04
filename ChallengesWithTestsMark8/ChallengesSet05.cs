using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do { startNumber++; } while (startNumber % n != 0);
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null) { return 0; }
            int sum = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }
            var sentence = new List<string>(words);
            bool lettersExist = false;
            for(int i = 0; i < sentence.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(sentence[i]) == true)
                {
                    sentence.RemoveAt(i);
                }
                var charArr = sentence[i].ToCharArray();
                foreach(var c in charArr)
                {
                    if (Char.IsLetter(c))
                    {
                        lettersExist = true;
                    }                   
                }
                sentence[i] = String.Concat(sentence[i].Where(c => !Char.IsWhiteSpace(c)));
            }
            if(lettersExist == false) { return ""; }
            sentence[sentence.Count - 1] += ".";
            return String.Join(" ", sentence);           
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null) { return new double[0]; }
            var list = new List<double>();
            for(int i = 0; i < elements.Count; i++)
            {
                if((i+1) % 4 == 0)
                {
                    list.Add(elements[i]);
                }
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums.Length < 2) { return false; }
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
