//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
byte GetSecondDigit(int number)
{
  return Convert.ToByte((number / 10) % 10);
}

Console.Write("Введите трехзначное чиcло: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 1000)
{
  byte DigitTwo = GetSecondDigit(Number);
  Console.WriteLine($"Вторая цифра чиcла {Number}: {DigitTwo}");
}
else
{
  Console.WriteLine("Чиcло должно быть трехзначным!");
}