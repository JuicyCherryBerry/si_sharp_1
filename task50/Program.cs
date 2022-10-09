/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
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
Console.WriteLine("Введите интересующий вас номер позиции");
int numberPosicion = Convert.ToInt32(Console.ReadLine());
void posicion(int[,] arrayToCount)
{
    int count = 0;
    for (int i = 0; i < arrayToCount.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToCount.GetLength(1); j++)
        {
            if (count == numberPosicion)
            {
                Console.WriteLine($"На заданной позиции стоит число {arrayToCount[i,j]}");
            }
            count++;
        } 
        count++;
       
    }
    if (count < numberPosicion)
    {
        Console.WriteLine("Числа с таким порядковым номером в массиве нет");
    }
}
int[,] generatedArray = generate2Darray(m, n, -100, 100);
print2Darray(generatedArray);
posicion(generatedArray);
