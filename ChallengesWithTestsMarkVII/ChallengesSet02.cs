using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {           
            if (vals.Count() % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null && numbers.Count() > 0)
            {
                double theMax = numbers.Max();
                double theMin = numbers.Min();

                return theMax + theMin;
            }
            else
            {
                return 0;
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            string[] words = {str1, str2};

            int shortestWord = words.Min(w => w.Length);

            return shortestWord;
        }

        public int Sum(int[] numbers)
        {         
            if (numbers != null && numbers.Count() > 0)
            {
                int sum1 = numbers.Sum();
                return sum1;
            }
            else
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int sum = 0;

            foreach (int num in numbers)
            {
                if (IsEven(num))
                {
                    sum += num;
                }
            }
            return sum;
        } 

        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null && numbers.Sum() % 2 != 0 )
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number / 2 < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
