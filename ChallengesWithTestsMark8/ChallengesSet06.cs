using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null)) { return false; }
            return ignoreCase ? words.Select(x => x.ToLower()).Contains(word.ToLower()) : words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2 || num == 3)
                return true;

            if (num <= 1 || num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 6; i * i <= num; i += 6)
            {
                if (num % (i - 1) == 0 || num % (i + 1) == 0)
                    return false;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {            
            if (string.IsNullOrEmpty(str)) { return -1; }
            char c;            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                c = str[i];
                if (!str.Remove(i, 1).Contains(c)) { return str.IndexOf(c); }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            var countList = new List<int>();
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] == numbers[i + 1]) { count++; }
                else
                {
                    countList.Add(count);
                    count = 1;
                }
            }
            countList.Add(count);
            return countList.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || elements.Count == 0 || n < 0) { return new double[0]; }
            var answerList = new List<double>();
            for(int i = n - 1; i < elements.Count; i += n)
            {
                answerList.Add(elements[i]);
            }
            return answerList.ToArray();
        }
    }
}
