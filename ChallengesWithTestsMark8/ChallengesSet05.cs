using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i= startNumber;
            while ((i % n) != 0)
            {
                i++;
            }
            return i;

           
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i=0; i< businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue== 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
                
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            for(int i =0; i<numbers.Length-1; i++)
            {
                if(numbers[i] > numbers[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if ((numbers[i + 1] % 2) == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = words[0];
            for(int i=1; i< words.Length; i++)
            {
                sentence = sentence + " ";
            }
            sentence = sentence + ".";
            return sentence;
        }


        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] tree = new double[elements.Count / 4];
            int j = 0;
            for(int i= 0; i<elements.Count; i= i+3)
            {
                tree[j] = elements[i];
                j++;
            }
            return tree;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                    {
                        return false;
                    }

                }
            }
        }