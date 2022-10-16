/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
void sortedArray(int[,] arrayToSort)
{
    for (int i = 0; i < m; i++)
    {
      //  int max = arrayToSort[i,0];
        for (int j = 0; j <  n-1; j++)
       {
            for (int k = j + 1; k < n; k++)
            {
                if (arrayToSort[i,j] < arrayToSort[i,k])
                    {
                        int buf = arrayToSort[i,j];
                        arrayToSort[i,j] = arrayToSort[i,k];
                        arrayToSort[i,k] = buf;
                    }
            }           
        }
    }
    print2Darray(arrayToSort);
}
int[,] generatedArray = generate2Darray(m, n, 0, 100);
print2Darray(generatedArray);
Console.WriteLine();
sortedArray(generatedArray);