﻿// Задача 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();

Console.Write("Введите целые числа через пробел, а я посчитаю количество чисел больше нуля: ");
string[] s = Console.ReadLine().Split(' ');
int[] array = new int[s.Length];
int count = 0;
for (int i = 0; i < s.Length; i++)
{
    array[i] = Convert.ToInt32(s[i]);
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел > 0: {count}");
