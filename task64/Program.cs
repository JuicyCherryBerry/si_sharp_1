/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
getNumbers(number);
void getNumbers(int N)
{
    if (N == 1)
    {
        Console.Write($"{N}");
        Console.WriteLine();
        Console.WriteLine();
        return;
    }
    Console.Write($"{N}, ");
    getNumbers(N-1);
    
}
