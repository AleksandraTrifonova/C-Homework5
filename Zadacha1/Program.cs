// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Задайте коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Задайте коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Задайте коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Задайте коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine()?? "0");
int x = 0;
int y = 0;
// Необходимо решить систему из 2-х уравнений:
// k1 * x + b1 = k2 * x + b2
// x = (b2 - b1) / (k1 - k2)
if (k1 == k2) Console.WriteLine("При заданных коэфициентах прямые не пересекаются");
else
{ 
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты x = {x}, y = {y}");
}

