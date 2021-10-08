using System;

namespace DigitalRoot
{
    public class Number
    {
        // public int DigitalRoot(long n) //понравилось решение
        // {
        //     return (int)(1 + (n - 1) % 9);
        // }
        public int FindDigitalRoot(long n)
        {
            int digitalRoot = 0;

            while (n > 0)
            {
                digitalRoot += (int)(n % 10);
                n = n / 10;
            }

            if (digitalRoot <= 9)
                return digitalRoot;
            
            return FindDigitalRoot(digitalRoot);
            }
        
        public static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine(number.FindDigitalRoot(493193));
        }
    }
}