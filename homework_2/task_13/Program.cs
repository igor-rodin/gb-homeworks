// Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток.

int GetRemainder(int Number, int Divisor)
{
  return Number % Divisor;
}

Console.Write("Введите первое чиcло: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло: ");
int Divisor = Convert.ToInt32(Console.ReadLine());

int Remainder = GetRemainder(Number, Divisor);

if (Remainder == 0)
{
  Console.WriteLine($"Число {Number} кратно {Divisor}");
}
else
{
  Console.WriteLine($"Остаток от деления {Number} на {Divisor}: {Remainder}");
}