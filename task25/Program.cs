/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Введите число А: ");
Console.Write("А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for(int stepen = 1; stepen < B; stepen++)
{
    result = result * A;
}
Console.WriteLine($"A в степени B равно {result}");