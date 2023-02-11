﻿// Console.Clear();
// Console.WriteLine("Task 34");
// Console.WriteLine("------");

// void InputArray1(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 1000);
// }


// int ReleaseArray1(int[] array)
// {
//   int count = 0;
//   foreach (int item in array)
//   {
//     if (item%2 == 0) count++;
//   }
//   return count;
// }

// int[] array1 = new int[10];
// InputArray1(array1);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array1)}]");
// Console.WriteLine($"Количество четных элементов: {ReleaseArray1(array1)}");

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 36");
// Console.WriteLine("------");

// void InputArray2(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 10);
// }


// int ReleaseArray2(int[] array)
// {
//   int sum = 0;
//   for (int i = 1; i < array.Length; i+=2)
//   {
//     sum += array[i];
//   }
//   return sum;
// }

// int[] array2 = new int[8];
// InputArray2(array2);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array2)}]");
// Console.WriteLine($"Сумма элементов на нечетных позициях: {ReleaseArray2(array2)}");

// Console.ReadLine();

// /*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 38");
Console.WriteLine("------");

void InputArray3(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble()*100, 2);
}


double ReleaseArray3(double[] array)
{
    double max = 0, min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine(min);
    Console.WriteLine(max);
    return Math.Round(max - min,2);
}

double[] array3 = new double[8];
InputArray3(array3);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array3)}]");
Console.WriteLine($"Разница между минимальным и максимальным значениями: {ReleaseArray3(array3)}");

Console.ReadLine();

/*--------------------------------------------*/