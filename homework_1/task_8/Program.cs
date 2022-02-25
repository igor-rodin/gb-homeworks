Console.Write("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные чиcла от 1 до {number}:");
for (int i = 2; i <= number; i += 2)
{
  Console.Write($" {i}");
}
Console.WriteLine("");