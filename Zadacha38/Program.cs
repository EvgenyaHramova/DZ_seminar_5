/*Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементом массива.
 [3 7 22 2 78] -> 76
*/

double[] array = new double[new Random().Next(2, 5)];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] =  rand.Next(-10, 11) + rand.NextDouble();
    Console.Write(array[i] + " ");
} 

Console.WriteLine();

double Difference(double[] array)
{
    double min = array[0];
    double max = 0;
    double diff = 0;
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
