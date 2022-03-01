// Задача 15: Дано число. Проверить кратно ли оно 7 и 23
int GetRemainder(int Number, int Divisor)
{
  return Number % Divisor;
}

Console.Write("Введите чиcло: ");
int Number = Convert.ToInt32(Console.ReadLine());

int Remainder7 = GetRemainder(Number, 7);
int Remainder23 = GetRemainder(Number, 23);

if (Remainder7 == 0 && Remainder23 == 0)
{
  Console.WriteLine($"Число {Number} кратно 7 и 23");
}
else if (Remainder7 == 0)
{
  Console.WriteLine($"Число {Number} кратно 7");
}
else if (Remainder23 == 0)
{
  Console.WriteLine($"Число {Number} кратно 23");
}
else
{
  Console.WriteLine($"Число {Number} не кратно 7 и 23");
}
