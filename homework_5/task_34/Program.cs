// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
using System.Text;

//Создание массива целых чисел в диапазоне от MinValue до MaxValue
int[] CreateIntArray(int Size, int MinValue = 100, int MaxValue = 1000)
{
  int[] Result = new int[Size];

  Random genInt = new Random();
  for (int i = 0; i < Size; i++)
  {
    Result[i] = genInt.Next(MinValue, MaxValue);
  }

  return Result;
}

void PrintArray(int[] Array)
{
  String separator = ", ";
  StringBuilder stringBuilder = new StringBuilder("[");
  for (int i = 0; i < Array.Length - 1; i++)
  {
    stringBuilder.Append(Array[i]).Append(separator);
  }
  stringBuilder.Append(Array[Array.Length - 1]).Append("]");

  Console.WriteLine(stringBuilder.ToString());
}

int EvensCount(int[] Array)
{
  int Result = 0;

  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] % 2 == 0)
    {
      Result++;
    }
  }

  return Result;
}

Console.Write("Введите размер массива: ");
int ArrSize = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateIntArray(ArrSize);
PrintArray(Array);
Console.WriteLine($"Количество четных элементов в массиве: {EvensCount(Array)}");