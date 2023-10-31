using System;

namespace SmallestDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int smallestDigit = 9;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit < smallestDigit)
                {
                    smallestDigit = digit;
                }
                number /= 10;
            }

            Console.WriteLine($"Наименьшая цифра в числе: {smallestDigit}");
        }
    }
}
