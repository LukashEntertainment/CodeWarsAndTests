using System;

namespace PasswordCheck
{
    public class PasswordChecker
    {
        public string DecodePass(string[] passArr, string bin)
        {
            string result = "";
            var bins = bin.Split(' '); // получаем массив строк деля по пробелам

            foreach (string binNum in bins)
            {
                var character = Convert.ToInt32(binNum, 2); //число в формате строки и из какого формата необъодимо преобразовать
                result += Convert.ToChar(character); // преобразуем число в символ и прибавим к результату
            }

            for (int i = 0; i < passArr.Length; i++) // сравниваем полученный результат с массивом паролей
            {
                if (result == passArr[i])
                {
                    return result;
                }
            }

            return null;
        }
        
        public static void Main(string[] args)
        {
            PasswordChecker passwordChecker = new PasswordChecker();
            string[] arr = {"password123", "admin", "admin1"};

            Console.WriteLine(passwordChecker.DecodePass(arr,
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        }
    }
}