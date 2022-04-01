// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

int[,] CreateTwoDimensionalArray(int countRows, int countColumns, int minValue = -10, int maxValue = 10)
{
  int[,] result = new int[countRows, countColumns];

  Random numberGen = new Random();

  for (int i = 0; i < countRows; i++)
  {
    for (int j = 0; j < countColumns; j++)
    {
      result[i, j] = numberGen.Next(minValue, maxValue + 1);
    }
  }

  return result;
}
//-------------------------------------------------------------------
void PrintTwoDimensionalArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],5}");
    }
    Console.WriteLine("  |");
  }
}
//-------------------------------------------------------------------

void DoubleAtOddIndexes(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i % 2 == 1 && j % 2 == 1)
      {
        array[i, j] *= array[i, j];
      }
    }
  }
}
//-------------------------------------------------------------------

Console.WriteLine("Веедите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = CreateTwoDimensionalArray(m, n);
PrintTwoDimensionalArray(array);
DoubleAtOddIndexes(array);
Console.WriteLine();
PrintTwoDimensionalArray(array);
