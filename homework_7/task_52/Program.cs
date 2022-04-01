// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void PrintArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i],6:f2}");
  }
  Console.WriteLine(" ]");
}
//-------------------------------------------------------------------
double[] GetMeanArray(int[,] array)
{
  double[] meanArray = new double[array.GetLength(1)];

  for (int i = 0; i < array.GetLength(1); i++)
  {

    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
      sum += array[j, i];
    }
    meanArray[i] = sum / array.GetLength(0);
  }

  return meanArray;
}
//-------------------------------------------------------------------

Console.WriteLine("Веедите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = CreateTwoDimensionalArray(m, n);
double[] meanArray = GetMeanArray(array);

PrintTwoDimensionalArray(array);
Console.WriteLine();
PrintArray(meanArray);
