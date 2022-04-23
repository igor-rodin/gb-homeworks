//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
byte GetSecondDigit(int number)
{
  return Convert.ToByte((Math.Abs(number) / 10) % 10);
}

Console.Write("Введите трехзначное чиcло: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(Number) > 99 && Math.Abs(Number) < 1000)
{
  byte DigitTwo = GetSecondDigit(Number);
  Console.WriteLine($"Вторая цифра чиcла {Number}: {DigitTwo}");
}
else
{
  Console.WriteLine("Чиcло должно быть трехзначным!");
}