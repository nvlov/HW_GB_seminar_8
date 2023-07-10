/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		// Запрос размера массива
        Console.Write("Введите размер квадратного массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание квадратного массива заданного размера
        int[,] array = new int[n, n];

        // Определение границ для заполнения спирали
        int left = 0, right = n - 1, top = 0, bottom = n - 1;
        int num = 1;

        while (num <= n * n)
        {
            // Заполнение верхней границы слева направо
            for (int i = left; i <= right; i++)
            {
                array[top, i] = num;
                num++;
            }
            top++;

            // Заполнение правой границы сверху вниз
            for (int i = top; i <= bottom; i++)
            {
                array[i, right] = num;
                num++;
            }
            right--;

            // Заполнение нижней границы справа налево
            for (int i = right; i >= left; i--)
            {
                array[bottom, i] = num;
                num++;
            }
            bottom--;

            // Заполнение левой границы снизу вверх
            for (int i = bottom; i >= top; i--)
            {
                array[i, left] = num;
                num++;
            }
            left++;
        }

        // Вывод массива на экран
        Console.WriteLine("Заполненный массив по спирали:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
