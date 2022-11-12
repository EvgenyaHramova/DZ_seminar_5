﻿/*Задайте одномерный массив,
заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/ 
int[] array = new int[new Random().Next(1, 10)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();


int Summa(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum= sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine(Summa(array));