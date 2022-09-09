using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if ( words == null || string.Equals(word, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> list = words.Select(x => x.ToLower()).ToList();

                containsWord = list.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = word.Contains(word);
            }

            return containsWord;

        }

        public bool IsPrimeNumber(int num)
        {
            int count = 0;
            if (num <= 1 || num == 4)
            {
                return false;
            }
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[i] == str[j])
                    {
                         uindex = false;
                    }
                }

                if (uindex == true)
                {
                    index = i;
                }
            }

            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i <= numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            if (elements == null || elements.Count == 0 || n < 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            double[] elementArray = elements.ToArray();

            for (int i = n - 1; i < elementArray.Length; i += n)
            {
                result.Add(elementArray[i]);
            }
            return result.ToArray();
        }
    }
}

                      

