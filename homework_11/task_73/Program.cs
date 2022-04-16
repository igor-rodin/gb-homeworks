// Задача 73: Есть число N. Сколько групп M можно получить при разбиении всех чисел на группы
//            так, чтобы в одной группе все числа были взаимно просты (все числа в группе не делятся друг на друга)?
//            Найдите M при заданном N и получите одно из разбиений на группы (N <= 10^20). 


void PrintGroups(int[] numbers, int groupsCount)
{
  for (int i = 0; i < groupsCount; i++)
  {
    Console.Write($"Группа {i + 1}: [");
    for (int j = 1; j < numbers.Length; j++)
    {
      if (numbers[j] == i + 1)
      {
        Console.Write($" {j}");
      }
    }
    Console.WriteLine(" ]");
  }
}
//--------------------------------------------------------
/// <summary>
/// Метод находит разбиния чисел от 1 до N на группы взаимно простых чисел
/// </summary>
/// <param name="numbers">Массив, значениями которого являются номера групп</param>
/// <param name="groupCount">Количество получившихся групп</param>
/// <param name="startIdx">Стартовое число для новой группы </param>
/// <param name="hasNextGroup">Есть ли еще группы (для выхода из рекурсии)</param>
void GetPrimes(int[] numbers, ref int groupCount, int startIdx = 3, bool hasNextGroup = true)
{
  if (!hasNextGroup)
  {
    groupCount--;
    return;
  };

  int nextGroupId = 0;
  bool isNewGroup = true;
  for (int i = startIdx; i < numbers.Length; i++)
  {
    bool isPrime = true;
    if (numbers[i] == groupCount)
    {
      for (int j = i - 1; j > startIdx - 2; j--)
      {
        if ((numbers[j] == groupCount) && (i % j == 0))
        {
          isPrime = false;
          break;
        }
      }
    }

    if (!isPrime)
    {
      numbers[i] = groupCount + 1;
      if (isNewGroup)
      {
        nextGroupId = i;
        isNewGroup = false;
      }
    }
  }

  groupCount++;

  GetPrimes(numbers, ref groupCount, startIdx = nextGroupId + 1, nextGroupId != 0);
}
//----------------------------------------------------------------------------

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// индексами массива numbers являются натуральные числа от 1 до N
// значениями массива являются номер группы разбиения к которому принадлежит число по этому индексу 
int[] numbers = new int[N + 1];
numbers[1] = 1; //Первая группа состоит из одного числа 1

int groupCount = 2;

for (int i = 2; i < N + 1; i++)
{
  numbers[i] = groupCount;
}


GetPrimes(numbers, ref groupCount);

Console.WriteLine($"Количество групп: {groupCount}");
//M = log2(N) (логарифм N по основанию 2, округленный до целого сверху)

PrintGroups(numbers, groupCount);