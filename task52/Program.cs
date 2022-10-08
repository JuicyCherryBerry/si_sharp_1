/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
Console.WriteLine("Введите размерность массива m*n: ");
Console.Write("количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
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
        printColorData(i + "\t");
    }
    Console.WriteLine();
     for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void srArifmStolb(int[,] arrayToSum)
{
    Console.WriteLine();
    for (int j = 0; j < arrayToSum.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arrayToSum.GetLength(0); i++)
        {
            sum = sum + arrayToSum[i,j];             
        }
        double srArifm = sum/m;
        Console.Write($"Среднее арифметическое столбца {j} равно {srArifm}");
        Console.WriteLine();
    }
}
int[,] generatedArray = generate2Darray(m, n, -100, 100);
print2Darray(generatedArray);
srArifmStolb(generatedArray);