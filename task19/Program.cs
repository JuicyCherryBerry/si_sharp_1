/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int ubraliPoryadok = N / 10;
int ostatok = N % 10;
int digitCount = 1;
while (ubraliPoryadok != 0)
{
   ubraliPoryadok = ubraliPoryadok / 10;
   ostatok = ubraliPoryadok % 10;
   digitCount++;
}
if (digitCount != 5)
{
    Console.WriteLine("Введите пятизначное число: ");
}
else
{
    int otsekliCifru = N / 10;
    int lastDigit = N % 10;
    int[] massivCifr = new int[5];
    int nomerElementaMassiva = 0;
    massivCifr[0] = lastDigit;
    for (nomerElementaMassiva = 1; nomerElementaMassiva < 5; nomerElementaMassiva++)
    {
        lastDigit = otsekliCifru % 10;
        otsekliCifru = otsekliCifru / 10;
        massivCifr[nomerElementaMassiva] = lastDigit;
    }
    if (massivCifr[0] == massivCifr[4] && massivCifr[1] == massivCifr[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
