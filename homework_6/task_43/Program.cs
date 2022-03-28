// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.
(double x, double y) FindCrossPoint(double k1, double b1, double k2, double b2)
{
  (double x, double y) result = (0, 0);

  result.x = (b2 - b1) / (k1 - k2);
  result.y = k1 * result.x + b1;

  return result;
}

Console.WriteLine("Программа находит точку пересечения прямых, заданных уравнением: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 != b2)
{
  Console.WriteLine("Прямые не пересекаются");
}
else if (k1 == k2 && b1 == b2)
{
  Console.WriteLine("Прямые совпадают (бесконечно много точек пересечения)");
}
else
{
  (double x, double y) point = FindCrossPoint(k1, b1, k2, b2);

  Console.WriteLine($"Точка пересечения: ({point.x}, {point.y})");
}