/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine();
Console.Write("Введите число M: ");
int Start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int End = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(getSumOfNumbers(Start, End));
int  getSumOfNumbers(int M, int N)
{
   
    if (N == M)
    {
        return N;
    }
    int sum = N;
    return sum+getSumOfNumbers(M, N-1);
}