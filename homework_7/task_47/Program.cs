// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] CreateTwoDimensionalArray(int countRows, int countColumns, double minValue = -10, double maxValue = 10)
{
  double[,] result = new double[countRows, countColumns];

  Random numberGen = new Random();

  for (int i = 0; i < countRows; i++)
  {
    for (int j = 0; j < countColumns; j++)
    {
      result[i, j] = minValue + numberGen.NextDouble() * (maxValue - minValue);
    }
  }

  return result;
}
//-------------------------------------------------------------------
void PrintTwoDimensionalArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],8:f3}");
    }
    Console.WriteLine("  |");
  }
}
//-------------------------------------------------------------------

Console.WriteLine("Веедите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

double[,] array = CreateTwoDimensionalArray(m, n);
PrintTwoDimensionalArray(array);
