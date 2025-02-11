﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                } 
              
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return sum % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var containsUpper = false;
            var containsLower = false;
            var containsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    containsUpper = true;
                }

                else if (char.IsLower(password[i]))
                {
                    containsLower = true;
                }

                else if (char.IsNumber(password[i]))
                {
                    containsNumber = true;
                }
            }

            if (containsUpper == true && containsLower == true && containsNumber == true)
            {
                return true;
            }
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return (val[0]);
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if ((i % 2 ) != 0 )
                {
                    list.Add(i);
                }
            }            
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
