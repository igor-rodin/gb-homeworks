// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица кубов чисел от 1 до {Number}");
Console.WriteLine("-----------------------------");
Console.WriteLine($"i: \ti^3");
Console.WriteLine("-----------------------------");
for (int i = 1; i <= Number; i++)
{
  Console.Write($"{i}: \t{Math.Pow(i, 3)}");
  Console.WriteLine();
}
