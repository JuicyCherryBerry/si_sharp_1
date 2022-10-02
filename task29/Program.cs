/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write("[");
for(int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 100);
    if (i < length - 1)
    {
        Console.Write(array[i] + ", ");
    }
    else
    {
        Console.WriteLine(array[length - 1] + "]");
    }
}
