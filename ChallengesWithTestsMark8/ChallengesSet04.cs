using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var add = numbers.Where(even => even % 2 == 0);
            
            var subtract = numbers.Where(odd => odd % 2 != 0);

            return add.Sum() - subtract.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            return stringList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberList = new List<int>() { number1, number2, number3, number4 };

            return numberList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = objs.Where(elements => elements == null);
            return majority.Count() > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var evenNumbers = numbers.Where(evens => evens % 2 == 0);

            if (evenNumbers.Count() == 0)
            {
                return 0;
            }
            else return evenNumbers.Average();

        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
