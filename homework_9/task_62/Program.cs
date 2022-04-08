// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру)

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
/// Метод заполняет спирально по часовой стрелке массив размера (M x N) натуральными числами в порядке возрастания
/// </summary>
/// <param name="array">Заполняемый массив</param>
void FillSpiralArray(int[,] array)
{
  int loopsCount = (array.GetLength(0) < array.GetLength(1)) ? array.GetLength(0) / 2 : array.GetLength(1) / 2;

  int turn = 0;
  int number = 1;
  while (turn < loopsCount)
  {
    //Заполняем верхнюю строку
    for (int j = turn; j < array.GetLength(1) - 1 - turn; j++)
    {
      array[turn, j] = number++;
    }
    //Заполняем крайний правый столбец
    for (int i = turn; i < array.GetLength(0) - 1 - turn; i++)
    {
      array[i, array.GetLength(1) - 1 - turn] = number++;
    }
    //Заполняем нижнюю строку
    for (int j = array.GetLength(1) - 1 - turn; j > turn; j--)
    {
      array[array.GetLength(0) - 1 - turn, j] = number++;
    }
    //Заполняем левый столбец
    for (int i = array.GetLength(0) - 1 - turn; i > turn; i--)
    {
      array[i, turn] = number++;
    }

    turn++;
  }
  //Краевые случаи
  //Количество столбцов нечетное и столбцов меньше строк
  if (array.GetLength(1) % 2 == 1 && (array.GetLength(0) >= array.GetLength(1)))
  {
    for (int i = turn; i < array.GetLength(0) - turn; i++)
    {
      array[i, array.GetLength(1) / 2] = number++;
    }
  }
  //Количество строк нечетное и строк меньше столбцов
  if (array.GetLength(0) % 2 == 1 && (array.GetLength(0) < array.GetLength(1)))
  {
    for (int j = turn; j < array.GetLength(1) - turn; j++)
    {
      array[array.GetLength(0) / 2, j] = number++;
    }
  }
}

//-------------------------------------------------------------
Console.WriteLine("Веедите размер массива (M N): ");
string[] sizeArray = Console.ReadLine().Split();
int m = Convert.ToInt32(sizeArray[0]);
int n = Convert.ToInt32(sizeArray[1]);

int[,] array = new int[m, n];
FillSpiralArray(array);
PrintTwoDimensionalArray(array);