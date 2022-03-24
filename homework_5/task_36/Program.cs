// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
using System.Text;

int[] CreateArray(int Size)
{
  int[] Result = new int[Size];

  Random genInt = new Random();
  for (int i = 0; i < Size; i++)
  {
    Result[i] = genInt.Next(-100, 100);
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

int OddsSum(int[] Array)
{
  int Result = 0;

  for (int i = 1; i < Array.Length; i += 2)
  {
    Result += Array[i];
  }

  return Result;
}

Console.Write("Введите размер массива: ");
int ArrSize = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArray(ArrSize);
PrintArray(Array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {OddsSum(Array)}");