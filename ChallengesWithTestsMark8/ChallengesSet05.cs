using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            var topIncrment = startNumber * n;
            var divisibleBy = 0;

            for (int i = startNumber; i < topIncrment; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    divisibleBy = i;
                    break;
                }
            }

            return divisibleBy;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
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
                if (numbers[i] < numbers[i - 1])
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

            List<int> evens = new List<int>();

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            return evens.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            int spaces = 0;
            int realWords = 0;
            List<string> sentence = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                {
                    spaces += 1;
                }
                else
                {
                    sentence.Add(words[i].Trim());
                    realWords += 1;
                }
            }

            if (realWords == 0)
            {
                return "";
            }
            else
            {
                return String.Join(" ", sentence) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            double[] elementArray = elements.ToArray();

            for (int i = 3; i < elementArray.Length; i+=4)
            {
                 result.Add(elementArray[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
               for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
