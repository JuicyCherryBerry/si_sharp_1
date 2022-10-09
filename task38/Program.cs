/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int arrayLength = new Random().Next(3, 21);
double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(double[] incomingArray)
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
double getDifferenceOfMaxMinArrayMembers(double[] incomingArray)
{
    double max = incomingArray[0];
    double min = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i ++)
    {
        if (incomingArray[i] > max)
        {
            max = incomingArray[i];
        }
        else
        {
            if (incomingArray[i] < min)
            {
                min = incomingArray[i];
            }
        }
    }
    Console.WriteLine($"Максимальный элемент массива {max}");
    Console.WriteLine($"Минимальный элемент массива {min}");
    double difference = max - min;
    Console.WriteLine($"Разность максимального и минимального элементов массива {difference}");
    return difference;
}
double[] currantArray = getRandomArray(arrayLength, -999, 999);
printArray(currantArray);
getDifferenceOfMaxMinArrayMembers(currantArray);
