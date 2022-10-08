/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Введите размерность массива m*n: ");
Console.Write("количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] generate2Darray(int heigth, int width, int randomStart, int randomEnd)
{
    double[,] twoDarray = new double[heigth,width];
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
void print2Darray(double[,] arrayToPrint)
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
double[,] generatedArray = generate2Darray(m, n, -100, 100);
print2Darray(generatedArray);