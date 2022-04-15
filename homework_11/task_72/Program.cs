// Задача 72: Заданы 2 массива: info и data.В массиве data хранятся двоичные представления нескольких чисел (без разделителя).  
//            В массиве info хранится информация о количестве бит, которые занимают числа из массива data. 
//            Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Пример:

// входные данные:

// data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = { 2, 3, 3, 1 }

// выходные данные:1, 7, 0, 1

//Комментарий: первое число занимает 2 бита(01-> 1); второе число занимает 3 бита (111 -> 7); 
//третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
using System.Text;

int[] data = { 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1 };
int[] info = { 2, 3, 3, 1, 4 };

int GetDecimal(int[] bits, int minIdx, int maxIdx)
{
  int number = 0;
  for (int i = minIdx; i < maxIdx + 1; i++)
  {
    number += bits[i] * (int)Math.Pow(2, maxIdx - i);
  }
  return number;
}
//---------------------------------------------------------
int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)
{
  int[] numbers = new int[sizes.Length];

  int startIdx = 0;
  int endIdx = -1;
  for (int i = 0; i < numbers.Length; i++)
  {
    startIdx = endIdx + 1;
    endIdx = endIdx + sizes[i];
    int number = GetDecimal(bits, startIdx, endIdx);
    numbers[i] = number;
  }

  return numbers;
}
//------------------------------------------------------
void PrintArray(int[] Array)
{
  String separator = ", ";
  StringBuilder stringBuilder = new StringBuilder("{");
  for (int i = 0; i < Array.Length - 1; i++)
  {
    stringBuilder.Append(Array[i]).Append(separator);
  }
  stringBuilder.Append(Array[Array.Length - 1]).Append("}");

  Console.WriteLine(stringBuilder.ToString());
}
//------------------------------------------------------

int[] decimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(decimalNumbers);
