// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите координаты по b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты по k1");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты по k2");
int k2 = Convert.ToInt32(Console.ReadLine());

double a1 = b2 - b1;
double a2 = k1 - k2;
double x = a1 / a2;

Console.WriteLine($"x = {x}");

double a3 = b2 - b1;
double a4 = k1 - k2;

double y = k1 * a3 / a4 + b1;

Console.WriteLine($"y = {y}");