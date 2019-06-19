using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int index = startNumber;
         
            for (int i = 0; i < index; i++)
            {
                index++;
                if (index % n == 0)
                {
                    return index;
                }
            }
          
            return n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumOfNumbers = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfNumbers += numbers[i + 1];
                }
            }
            return sumOfNumbers;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == " ")
                {
                    sentence += "";
                }
                else
                {
                    sentence += words[i] + " ";
                }
            }

            sentence += words[words.Length - 1];
            sentence = sentence.Trim();

            if (sentence.Length == 0)
            {
                return "";
            }
            else
            {
                sentence += ".";
            }

            return Regex.Replace(sentence, @"\s+", " ");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();

            double[] arr = { };

            if (elements == null)
            {
                return arr;
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);             
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
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
