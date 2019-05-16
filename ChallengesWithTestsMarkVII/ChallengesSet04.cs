using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number*-1);
                }
                else
                {
                    evenNumbers.Add(number);
                }
            }
            return oddNumbers.Sum() + evenNumbers.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> stringList = new List<int>
            {
                str1.Length,
                str2.Length,
                str3.Length,
                str4.Length
            };
            return stringList.Min();
        }
        

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
          if (number1 <= number2 && number1 <= number3 && number1 <= number4)
          {
                return number1;
          }
          else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
          {
                return number2;
          }
          else if (number3 <= number2 && number3 <= number2 && number3 <= number4)
          {
                return number3;
          }
          else
          {
                return number4;
          }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1 )
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            bool isNumeric = double.TryParse(input, out double n);
            return isNumeric;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }
            if (nullCount > objs.Length /2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            List<int> evenList = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenList.Add(number);
                }
            }
            if (evenList.Count == 0)
            {
                return 0;
            }
            return evenList.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {

                    factorial = factorial * i;
                }

                return factorial;
            }
        }
    }
}
