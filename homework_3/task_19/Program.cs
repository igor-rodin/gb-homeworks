//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool isNumberPalindrom(UInt64 Number)
{
  string NumberStr = Convert.ToString(Number);

  for (int i = 0; i < NumberStr.Length / 2; i++)
  {
    if (NumberStr[i] != NumberStr[NumberStr.Length - i - 1])
    {
      return false;
    }
  }

  return true;
}

Console.WriteLine("Введите число: ");
var Number = Convert.ToUInt64(Console.ReadLine());
bool isPalindrom = isNumberPalindrom(Number);

if (isPalindrom)
{
  Console.WriteLine($"Число {Number} палиндром");
}
else
{
  Console.WriteLine($"Число {Number} не палиндром");
}