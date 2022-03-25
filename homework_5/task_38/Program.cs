// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
using System.Text;

//Создание массива вещественных чисел в диапазоне от MinValue до MaxValue
double[] CreateDoubleArray(int Size, double MinValue = -10, double MaxValue = 10)
{
  double[] Result = new double[Size];

  Random genNumber = new Random();
  for (int i = 0; i < Size; i++)
  {
    Result[i] = MinValue + genNumber.NextDouble() * (MaxValue - MinValue);
  }

  return Result;
}

void PrintArray(double[] Array)
{
  String separator = ", ";
  StringBuilder stringBuilder = new StringBuilder("[");
  for (int i = 0; i < Array.Length - 1; i++)
  {
    stringBuilder.Append($"{Array[i]:f4}").Append(separator);
  }
  stringBuilder.Append($"{Array[Array.Length - 1]:f4}").Append("]");

  Console.WriteLine(stringBuilder.ToString());
}

double CalcMaxMinDiffrence(double[] Array)
{
  double MinValue = Array[0];
  double MaxValue = Array[0];

  for (int i = 1; i < Array.Length; i++)
  {
    if (Array[i] < MinValue)
    {
      MinValue = Array[i];
    }
    else if (Array[i] > MaxValue)
    {
      MaxValue = Array[i];
    }
  }

  return MaxValue - MinValue;
}

Console.Write("Введите размер массива: ");
int ArrSize = Convert.ToInt32(Console.ReadLine());
double[] Array = CreateDoubleArray(ArrSize);
PrintArray(Array);

double Diff = CalcMaxMinDiffrence(Array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Diff:f4}");