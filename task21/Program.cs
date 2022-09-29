/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double funrasstoyanie(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double kvadratRasstoyaniya = (xA - xB)*(xA - xB) + (yA - yB)*(yA - yB) + (zA - zB)*(zA - zB);
    double rasstoyanie = Math.Sqrt(kvadratRasstoyaniya);
    return rasstoyanie;
}
Console.WriteLine("Введите координаты точки А: ");
Console.Write("хА = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("yA = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("zA = ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В: ");
Console.Write("хВ = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("yВ = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("zВ = ");
double zB = Convert.ToDouble(Console.ReadLine());
double rasstoyanie = funrasstoyanie(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками равно {rasstoyanie} ");