/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите интересующее число: ");
int N = Convert.ToInt32(Console.ReadLine());
int otsekliCifru = N / 10;
int lastDigit = N % 10;
int digitCount = 1;
while (otsekliCifru != 0)
{
   otsekliCifru = otsekliCifru / 10;
   lastDigit = otsekliCifru % 10;
   digitCount++;
}
Console.WriteLine($"Количество цифр в числе {digitCount}");
if (digitCount < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int minusPoryadok = N / 10;
    int ostatok = N % 10;
    int i = 2;
    int k = digitCount - 2;
    while (i < k)
    {
        minusPoryadok = minusPoryadok / 10;
        ostatok = minusPoryadok % 10;
        i++;
    }
    Console.WriteLine($"Третья цифра слева {ostatok}");
}