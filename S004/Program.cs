﻿Console.Clear();

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] FillArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(2);
    }
    return array;
}
int[] array = FillArray();
System.Console.WriteLine(string.Join(", ", array)); // string.Join(", ",  соединяет через запятую в строку