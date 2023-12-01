// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
Random r = new Random();

int size = 10;
int count = 0;
int[] array = new int[size];

// Заполняем массив рандомными числами от 1 до 100
for (int i = 0; i < size; i++)
{
    array[i] = r.Next(1, 100);
    Console.WriteLine(array[i]);
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}

Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [20,90] - {count}");