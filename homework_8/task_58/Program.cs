// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

// <summary>
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
/// Метод находит произведение двух прямоугольных матриц А (m x n) и В (n x k)
/// </summary>
/// <param name="A">Матрица</param>
/// <param name="B">Матрица</param>
/// <returns>Произведение матриц А*В (m x k)</returns>
int[,] MatrixProduct(int[,] A, int[,] B)
{
  int mA = A.GetLength(0);
  int nA = A.GetLength(1);
  int kB = B.GetLength(1);

  int[,] result = new int[mA, kB];

  for (int i = 0; i < mA; i++)
  {
    for (int j = 0; j < kB; j++)
    {
      for (int k = 0; k < nA; k++)
      {
        result[i, j] += A[i, k] * B[k, j];
      }

    }
  }

  return result;
}

//-----------------------------------------------------------
(int m, int n) GetInputSize(string inputMessage)
{
  Console.WriteLine(inputMessage);
  string[] size = Console.ReadLine().Split();
  return (Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));
}
//--------------------------------------------------------------

int nA, mA;
int nB, mB;

while (true)
{
  (mA, nA) = GetInputSize("Введите размер матрицы A (m x n)");
  (mB, nB) = GetInputSize("Введите размер матрицы B (n x k)");

  if (nA != mB)
  {
    Console.WriteLine("Количество столбцов n матрицы A должно быть равно количеству строк n матрицы B");
  }
  else
  {
    break;
  }
}

int[,] A = CreateTwoDimensionalArray(mA, nA, -3, 3);
Console.WriteLine("Матрица A:");
Console.WriteLine("-----------");
PrintTwoDimensionalArray(A);

int[,] B = CreateTwoDimensionalArray(mB, nB, -3, 3);
Console.WriteLine("Матрица B:");
Console.WriteLine("-----------");
PrintTwoDimensionalArray(B);
Console.WriteLine();

int[,] C = MatrixProduct(A, B);
Console.WriteLine("Произведение матриц A*B:");
Console.WriteLine("--------------------------");
PrintTwoDimensionalArray(C);