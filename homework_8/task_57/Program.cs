/// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int FindIndexOfValue(int[,] array, int value)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (array[i, 0] == value)
    {
      return i;
    }
  }
  return -1;
}
//---------------------------------------------
(int[,] freqs, int size) FrequencyAnalize(int[,] matrix)
{
  int[,] result = new int[matrix.GetLength(0) * matrix.GetLength(1), 2];
  for (int i = 0; i < result.GetLength(0); i++)
  {
    result[i, 0] = Int32.MinValue;
  }

  int freeIdx = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int idx = FindIndexOfValue(result, matrix[i, j]);
      if (idx != -1)
      {
        result[idx, 1]++;
      }
      else
      {
        result[freeIdx, 0] = matrix[i, j];
        result[freeIdx++, 1] = 1;
      }
    }
  }
  return (result, freeIdx);
}
//---------------------------------------------
void SortByColumn(int[,] array, int column)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int maxIndex = i;
    for (int j = i + 1; j < array.GetLength(0); j++)
    {
      if (array[j, column] > array[maxIndex, column])
      {
        maxIndex = j;
      }
    }
    if (maxIndex != i)
    {
      int tmp = array[i, column];
      array[i, column] = array[maxIndex, column];
      array[maxIndex, column] = tmp;
    }
  }
}
//---------------------------------------------
Console.WriteLine("Веедите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = CreateTwoDimensionalArray(m, n, -5, 10);
//PrintTwoDimensionalArray(array);

(int[,] freqs, int size) = FrequencyAnalize(array);

SortByColumn(freqs, 1);//Сортируем по убыванию количества нахождений элементов в массиве

Console.WriteLine("Частотный словарь элементов в массиве");
Console.WriteLine("-----------------------------------");
Console.WriteLine("| Число | В процентах |Количество |");
Console.WriteLine("|-------+-------------+-----------|");
for (int i = 0; i < size; i++)
{
  Console.Write("|");
  Console.Write($" {freqs[i, 0],4}  |   {100.0 * freqs[i, 1] / (m * n),6:f1}%   |   {freqs[i, 1],4}  ");
  Console.WriteLine("  |");
}
Console.WriteLine("-----------------------------------");