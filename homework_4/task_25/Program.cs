// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Power(int A, int B)
{
  double result = 1;
  for (int i = 1; i <= Math.Abs(B); i++)
  {
    result *= A;
  }

  return (B >= 0) ? result : 1 / result;
}

Console.WriteLine("Возведение числа A в степень B");
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {NumberA} в степени {NumberB}: {Power(NumberA, NumberB)}");