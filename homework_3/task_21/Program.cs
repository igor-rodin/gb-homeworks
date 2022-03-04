//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
  return Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));
}

Console.WriteLine("Введите координату X первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());


double distance = GetDistance(X1, Y1, Z1, X2, Y2, Z2);

Console.WriteLine($"Расстояние между точками ({X1}, {Y1}, {Z1})  и  ({X2}, {Y2}, {Z2}): {distance:f3}");

