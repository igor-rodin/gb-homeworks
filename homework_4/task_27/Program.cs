//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits(int Number)
{
  int result = 0;
  int PosNumber = Math.Abs(Number);
  while (PosNumber > 0)
  {
    int Digit = PosNumber % 10;
    result += Digit;
    PosNumber /= 10;
  }
  return result;
}

//Второй способ через ковертацию в строку
int SumOfDigits2(int Number)
{
  String StrNumber = Convert.ToString(Math.Abs(Number));

  int result = 0;
  for (int i = 0; i < StrNumber.Length; i++)
  {
    result += StrNumber[i] - '0';
  }

  return result;
}


Console.WriteLine("Найти сумму цифр числа");
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {Number}: {SumOfDigits(Number)}");
Console.WriteLine($"Сумма цифр числа {Number} (второй способ): {SumOfDigits2(Number)}");