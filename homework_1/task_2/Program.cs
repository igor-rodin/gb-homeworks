Console.Write("Введите первое чиcло: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a = {firstNumber}");
Console.WriteLine($"b = {secondNumber}");

if (firstNumber > secondNumber)
{
  Console.WriteLine($"Max = {firstNumber}");
}
else
{
  Console.WriteLine($"Max = {secondNumber}");
}


