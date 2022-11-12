/*Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементом массива.
 [3 7 22 2 78] -> 76
*/
int[] array = new int[new Random().Next(2, 10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();


int Difference(int[] array)
{
    int min = array[0];
    int max = 0;
    int diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        else if (array[i] <= min)
        {
            min = array[i];
        }

    }
    Console.WriteLine($"Минимальное значение элемента массива: {min};");
    Console.WriteLine($"Максимальное значение элемента массива: {max};");
    diff = max - min;
    return diff;
}

Console.WriteLine("Разница между максимальным и минимальным элементами равна:  " + Difference(array));
