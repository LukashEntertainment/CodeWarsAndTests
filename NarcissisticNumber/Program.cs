using System;
using System.Collections.Generic;

namespace NarcissisticNumber
{
    public class NarcissisticNumberClass
    {
        public bool NarcissisticNumberCheck(int number)
        {
            int digitNumber = 0;
            int defaultNumber = number;
            double newNumber = 0;
            List<int> digits = new List<int>();

            while (number > 0)
            {
                digits.Add(number % 10);
                number = number / 10;
                digitNumber += 1;
            }

            for (int i = 0; i < digitNumber; i++)
            {
                newNumber += Math.Pow(digits[i], digitNumber);
            }

            if (defaultNumber == newNumber)
            {
                return true;
            }

            return false;
        }

        public static void Main(string[] args)
        {
            NarcissisticNumberClass nn = new NarcissisticNumberClass();
            Console.WriteLine(nn.NarcissisticNumberCheck(1652));
        }
    }
}