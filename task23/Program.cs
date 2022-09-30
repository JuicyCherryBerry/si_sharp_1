/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] massivKubov = new int[N];
int number = 1;
int arrayArgNumber = 0;
massivKubov[0] = 1;
Console.WriteLine("Таблица кубов имеет вид: ");
while(number < (N + 1) && arrayArgNumber < N)
{
    int kubOfNumber = number*number*number;
    massivKubov[arrayArgNumber] = kubOfNumber;
    Console.Write(massivKubov[arrayArgNumber].ToString() + " ");
    number++;
    arrayArgNumber++;
}