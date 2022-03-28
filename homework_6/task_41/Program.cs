// Задача 41. Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositiveInputs(int InputLength)
{
  int CountPositive = 0;
  for (int i = 0; i < InputLength; i++)
  {
    int Number = Convert.ToInt32(Console.ReadLine());
    if (Number > 0)
    {
      CountPositive++;
    }
  }

  return CountPositive;
}

Console.WriteLine("Задайте количество чисел, которое хотите ввести: ");

int InputLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь вводите");

int CountPositive = CountPositiveInputs(InputLength);

Console.WriteLine($"Положительных чисел: {CountPositive}");



