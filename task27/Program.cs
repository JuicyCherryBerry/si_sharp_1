/* 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int otsekliCifru = N / 10;
int lastDigit = N % 10;
int sum = lastDigit;
while (otsekliCifru != 0)
{
   lastDigit = otsekliCifru % 10;
   otsekliCifru = otsekliCifru / 10;
   sum = sum + lastDigit;
}
Console.WriteLine($"Сумма цифр в числе N равна {sum}");