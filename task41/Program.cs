/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
int M = new Random().Next(1, 99);
Console.WriteLine($"Введите {M} чисел");
int[] NumbersArray = new int[M];
int count = 0;
for (int i = 0; i < M-1; i++)
{
    NumbersArray[i] = Convert.ToInt32(Console.ReadLine());
    if (NumbersArray[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввел {count} положительных чисел");