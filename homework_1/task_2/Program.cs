Console.Write("Введите первое чиcло: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a = {firstNumber}");
Console.WriteLine($"b = {secondNumber}");

int maxNumber = firstNumber;
int minNumber = firstNumber;

if (firstNumber > secondNumber)
{
  minNumber = secondNumber;
}
else
{
  maxNumber = secondNumber;
}
Console.WriteLine($"Максимальное число -> {maxNumber}");
Console.WriteLine($"Минимальное число -> {minNumber}");


