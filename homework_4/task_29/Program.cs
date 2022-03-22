// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System.Text;

int[] MakeRandomArray(int Size)
{
  int[] Result = new int[Size];
  Random RandomGen = new Random();
  for (int i = 0; i < Size; i++)
  {
    Result[i] = RandomGen.Next();
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

Console.Write("Введите размер массива: ");
int ArrSize = Convert.ToInt32(Console.ReadLine());
int[] Arr = MakeRandomArray(ArrSize);
PrintArray(Arr);