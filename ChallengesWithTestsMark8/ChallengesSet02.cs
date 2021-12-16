using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            if (lowercaseAlphabet.Contains(c))
                return true;
            else 
                return false;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if ((vals.Length % 2) == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if ((number % 2) == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if ((num % 2) == 0)

                return false;
            else
                return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double minvalue = -9999999;
            double maxvalue = 9999999;
            foreach(double num in numbers)
            {
                if (minvalue > num)
                    minvalue = num;
                if (maxvalue < num)
                    maxvalue = num;
         
            }
            return minvalue + maxvalue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int l1 = str1.Length;
            int l2 = str2.Length;
            if (l1 < l2)
                return l1;
            else
                return l2;
        }

        public int Sum(int[] numbers)
        {
            int sum1 = 0;
            foreach(int num in numbers)
            {
                sum1 = sum1 + num;
            }
            return sum1;
        }

        public int SumEvens(int[] numbers)
        {
            int sum1 = 0;
            for (int i = 0; i < numbers.Length; i = i+2 )
            {
                sum1 = sum1 + numbers[i];
            }
            return sum1;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum1 = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum1 = sum1 + numbers[i];
                
            }
            if ((sum1 % 2) == 0)
                return true;
            else
                return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddCount = 0;
            for(int i = 1; i <= number; i= i + 2)
            {
                oddCount = oddCount + 1;
            }
            return oddCount;
            
        }
    }
}
