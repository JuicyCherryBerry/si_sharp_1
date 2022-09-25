/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Дни недели имеют следующие номера:");
Console.WriteLine("Понедельник - 1");
Console.WriteLine("Вторник - 2");
Console.WriteLine("Среда - 3");
Console.WriteLine("Четверг - 4");
Console.WriteLine("Пятница - 5");
Console.WriteLine("Суббота - 6");
Console.WriteLine("Воскресенье - 7");
Console.WriteLine("Введите номер интересующего дня недели: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 1 || N == 2 || N == 3 || N == 4 || N == 5)
{
    Console.WriteLine("Это не выходной");
}
else if (N == 6 || N == 7)
{
    Console.WriteLine("Это выходной");
}