// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


double[] array = new double[] { 12.0129, 1.120, -2.153, 1765.03248, -29.3918, 47.19238 };
double max = array[0];
double min = array[0];


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Минимальное число - {min}");
Console.WriteLine($"Максимальное число - {max}");
Console.WriteLine($"разница между максимальным и минимальным элементов массива - {max - min}");


