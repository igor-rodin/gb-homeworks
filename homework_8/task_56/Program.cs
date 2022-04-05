// Задача 56: Задайте прямоугольный двумерный массив. 
//            Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/// <summary>
/// Метод генерирует двумерный массив, заполненный случайными целыми числами
/// </summary>
/// <param name="countRows">Количество строк массива</param>
/// <param name="countColumns">Количество колонок массива</param>
/// <param name="minValue">Минимальное значение элемента массива</param>
/// <param name="maxValue">Максимальное значение элемента массива</param>
/// <returns>Сгенерированный массив</returns>
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
/// <summary>
/// Выводит на консоль двумерный массив
/// </summary>
/// <param name="array">Выводимый массив</param>
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

/// <summary>
/// Метод находит в прямоугольном массиве строку с минимальной суммой элементов
/// </summary>
/// <param name="array">Массив</param>
/// <returns>Кортеж, состоящий из индекса row найденной строки и суммы элементов sum этой строки</returns>
(int row, int sum) GetRowWithMinSum(int[,] array)
{
  int minSum = int.MaxValue;
  int minIndex = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      rowSum += array[i, j];
    }
    if (rowSum < minSum)
    {
      minSum = rowSum;
      minIndex = i;
    }
  }

  return (minIndex, minSum);
}
//--------------------------------------------------------------------------
Console.WriteLine("Введите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = CreateTwoDimensionalArray(m, n);
PrintTwoDimensionalArray(array);
(int row, int rowSum) = GetRowWithMinSum(array);
Console.WriteLine($"Индекс строки с минимальной суммой -{row,3} (сумма: {rowSum,3})");