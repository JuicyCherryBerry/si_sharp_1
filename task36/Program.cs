/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/
int arrayLength = new Random().Next(3, 21);
int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int sum = 0;
int getSumOfNotEvenPosNumbers(int[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i += 2)
    {
        sum = sum + incomingArray[i];
    }
    return sum;
}

int[] currantArray = getRandomArray(arrayLength, -999, 999);
printArray(currantArray);
getSumOfNotEvenPosNumbers(currantArray);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {sum}");