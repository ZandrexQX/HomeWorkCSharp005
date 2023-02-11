Console.Clear();
Console.WriteLine("Task 34");
Console.WriteLine("------");

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}


int ReleaseArray(int[] array)
{
  int count = 0;
  foreach (int item in array)
  {
    if (item%2 == 0) count++;
  }
  return count;
}

int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов: {ReleaseArray(array)}");

Console.ReadLine();

/*--------------------------------------------*/