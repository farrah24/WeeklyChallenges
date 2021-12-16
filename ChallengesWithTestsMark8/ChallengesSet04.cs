 using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumeven = 0;
            int sumodd = 0;
            for(int i = 0; i < numbers.Length; i= i + 2)
            {
                sumeven = sumeven + i;

            }
            for (int i = 1; i < numbers.Length; i = i + 2)
            {
                sumodd = sumodd + i;

            }
            return sumeven - sumodd;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = 0;
            if (str1.Length < str2.Length)
                shortestLength = str1.Length;
            else
                shortestLength = str2.Length;
            if (str3.Length < shortestLength)
                shortestLength = str3.Length;
            if (str4.Length < shortestLength)
                shortestLength = str4.Length;
            return shortestLength;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestnumber = 0;
            if (number1 < number2)
                smallestnumber = number1;
            else
                smallestnumber = number2;
            if (number3 < smallestnumber)
                smallestnumber = number3;
            if (smallestnumber < number4 )
                smallestnumber = number4;
            return smallestnumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2) > sideLength3 &&
               (sideLength2 + sideLength3) > sideLength1 &&
               (sideLength3 + sideLength1) > sideLength2)
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            int num = 0;
            
            bool success = int.TryParse(input, out num);
            return success;
        }
        

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int l = objs.Length;
            int num = 0;
            for(int i = 0; i < l; i++)
            {
                if(objs[i] == null)
                {
                    num++; 
                }

            }
            if (num > (l / 2))
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double average = 0;
            int numcount = numbers.Length;
            int numsum = 0;
            for(int i = 0; i < numbers.Length; i = i + 2)
            {
                numsum = numsum + i;
                numcount++;
            }
            average = numsum / numcount;
            return average;

        }

        public int Factorial(int number)
        {
            int num = 1;
            for (int i =1; i<=number; i++)
            {
                num = num * i;
            }
            return num;
        }
      
        
    }
}
