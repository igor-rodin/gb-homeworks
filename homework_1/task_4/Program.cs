Console.Write("Введите первое чиcло: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье чиcло: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a = {firstNumber}");
Console.WriteLine($"b = {secondNumber}");
Console.WriteLine($"c = {thirdNumber}");

int maxNumber = firstNumber;

if (secondNumber > maxNumber)
{
  maxNumber = secondNumber;
}

if (thirdNumber > maxNumber)
{
  maxNumber = thirdNumber;
}

Console.WriteLine($"Max = {maxNumber}");
