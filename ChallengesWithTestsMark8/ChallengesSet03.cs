using System;
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
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumodd = 0;
            foreach (int i in numbers)
            {
                if ((i % 2) == 1)
                    sumodd = sumodd + i;
            }
            if ((sumodd % 2) == 1)
                return true;
            else
                return false;

        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }

                if (isLower == true && isNumber == true && isUpper == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }
        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
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
                if (i % 2 != 0)
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




