//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//           по убыванию элементы каждой строки двумерного массива(в пределах всего массива).

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
/// Метод сортирует строки массива array в порядке убывания
/// </summary>
/// <param name="array">Сортируемый массив</param>
void SortArrowsByDesc(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int maxIndex = j;
      for (int k = j + 1; k < array.GetLength(1); k++)
      {
        if (array[i, k] > array[i, maxIndex])
        {
          maxIndex = k;
        }
      }
      if (maxIndex != j)
      {
        int tmp = array[i, j];
        array[i, j] = array[i, maxIndex];
        array[i, maxIndex] = tmp;
      }
    }
  }
}
//--------------------------------------------------------------------------
Console.WriteLine("Введите размер массива (m n): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = CreateTwoDimensionalArray(m, n);
PrintTwoDimensionalArray(array);
SortArrowsByDesc(array);
Console.WriteLine();
PrintTwoDimensionalArray(array);
