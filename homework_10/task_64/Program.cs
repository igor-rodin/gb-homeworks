// Задача 64 Задайте значения M и N. 
//           Напишите программу, которая выведет все натуральные числа в промежутке от M до N в обратном порядке.

/// <summary>
/// Метод выводит натуральные числа в диапазоне от M до N (M < N) в обратном порядке
/// </summary>
/// <param name="m">Начало диапазона</param>
/// <param name="n">Конец диапазона</param>
void PrintNaturalNumbers(int m, int n)
{
  Console.Write($"{n} ");
  if (m < n)
  {
    PrintNaturalNumbers(m, n - 1);
  }
}

//----------------------------------------------------------
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


PrintNaturalNumbers(m, n);
Console.WriteLine();