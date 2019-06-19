using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }
            return ignoreCase ?
                words.Any(s => s.Equals(word, StringComparison.OrdinalIgnoreCase)) :
                words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int uniques = -1;
            bool isDuplicate;
            for (int i = 0; i < str.Length; i++)
            {
                isDuplicate = false;

                for (int j = 0; j < str.Length; j++)
                {   
                    if ((str[i] == str[j]) && i != j)
                    {
                        isDuplicate = true;
                    }
                }

                if (isDuplicate == false)
                {
                    uniques = i;
                }
            }
            return uniques;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int newCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                    else if (numbers[i] != numbers[j])
                    {
                        i = j - 1;
                        break;
                    }
                }
                if (count > newCount)
                {
                    newCount = count;
                }                
            }
            return newCount;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            double[] arr = { };

            if (elements == null || n < 0)
            {
                return arr;
            }
            for (int i = 0; i < elements.Count; i ++)
            {
                if (elements[i] % n == 0)
                {
                    result.Add(elements[i]);
                }
            }
            return result.ToArray();
        }
    }
}
