/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int m = new Random().Next(3, 10);
int n = new Random().Next(3, 10);
int[,] generate2Darray(int heigth, int width, int randomStart, int randomEnd)
{
    int[,] twoDarray = new int[heigth,width];
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDarray[i,j] = new Random().Next(randomStart, randomEnd+1);
        }
    }
    return twoDarray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}
void print2Darray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+1 + "\t");
    }
    Console.WriteLine();
     for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+1 + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void minStringSum(int[,] arrayToSum)
{
    int[] SumArray = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j <  n; j++)
        {
            sum = sum + arrayToSum[i,j];       
        }
        SumArray[i] = sum;
    }
    Console.Write("[");
    for(int i = 0; i < m; i++)
    {
        if (i < m - 1)
        {
            Console.Write(SumArray[i] + ", ");
        }
        else
        {
            Console.WriteLine(SumArray[m - 1] + "]");
        }
}
    int min = SumArray[0];
    int imin = 0;
    for (int i = 1; i < m; i++)
    {
        if (SumArray[i] < min)
        {
            min = SumArray[i];
            imin = i;
            
        }        
    }
    Console.WriteLine($"Наименьшую сумму элементов имеет {imin+1} строка");
}
int[,] generatedArray = generate2Darray(m, n, 0, 100);
print2Darray(generatedArray);
Console.WriteLine();
minStringSum(generatedArray);