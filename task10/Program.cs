/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число N ");
int N = Convert.ToInt32(Console.ReadLine());
int getSecondDigitFromNumber(int N)
{
    int LastTwoDigits = N % 100;
    int secondDigit = LastTwoDigits / 10;
    return secondDigit;
}
int secondDigit = getSecondDigitFromNumber(N);
Console.WriteLine($"Вторая цифра в числе равна {secondDigit} ");