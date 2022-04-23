//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits(int Number)
{
  int Result = 0;
  int PosNumber = Math.Abs(Number);
  while (PosNumber > 0)
  {
    int Digit = PosNumber % 10;
    Result += Digit;
    PosNumber /= 10;
  }
  return Result;
}

//Второй способ через конвертацию числа в строку
int SumOfDigits2(int Number)
{
  String StrNumber = Convert.ToString(Math.Abs(Number));

  int Result = 0;
  char ZeroChar = '0';
  for (int i = 0; i < StrNumber.Length; i++)
  {
    Result += StrNumber[i] - ZeroChar;
  }

  return Result;
}


Console.WriteLine("Найти сумму цифр числа");
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {Number}: {SumOfDigits(Number)}");
Console.WriteLine($"Сумма цифр числа {Number} (второй способ): {SumOfDigits2(Number)}");