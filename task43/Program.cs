/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Введите угловой и линейный коэффициенты первой прямой y = k1*х + b1: ");
Console.Write("Угловой коэффициент k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Линейный коэффициент b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой и линейный коэффициенты второй прямой y = k2*х + b2: ");
Console.Write("Угловой коэффициент k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Линейный коэффициент b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;
    Console.Write($"Точка пересечения имеет координаты ({x}; {y})");
}
else 
{
    Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
}
