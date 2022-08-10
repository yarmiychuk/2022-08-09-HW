/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

Console.WriteLine("Вычисление координат точки пересечения через линейные уравнения");
Console.WriteLine("y = k1 * x + b1 и y = k2 * x + b2");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Линии пересекаются в точке с координатами x = {x}, y = {y}");
