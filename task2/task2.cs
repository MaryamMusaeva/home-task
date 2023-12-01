// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Random r = new Random();

int size = 10;
int count = 0;
int[] array = new int[size];

// Заполняем массив рандомными числами от 1 до 100
for (int i = 0; i < size; i++)
{
    array[i] = r.Next(1, 100);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"количество чётных чисел в массиве - {count}");