// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//            в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30


/// <summary>
/// Метод ищет сумму натуральных чисел в диапазоне от M до N (M < N)
/// </summary>
// <param name="m">Начало диапазона</param>
/// <param name="n">Конец диапазона</param>
/// <returns>Сумма чисел в дипазоне [M, N]</returns>
int SumOfNaturalNumbers(int m, int n)
{
  if (m == n)
  {
    return n;
  }
  return m + SumOfNaturalNumbers(m + 1, n);
}
//----------------------------------------------------------
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int sum = SumOfNaturalNumbers(m, n);

Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

