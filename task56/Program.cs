/*Задача 56. Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		// Запрос размеров массива у пользователя
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        // Создание двумерного массива и заполнение случайными числами
        int[,] array = CreateRandomArray(m, n);

        // Вывод исходного массива
        Console.WriteLine("\nИсходный массив: ");
        PrintArray(array);

        // Нахождение строки с наименьшей суммой элементов
        int minRow = FindRowWithMinSum(array);

        // Вывод номера строки с наименьшей суммой элементов
        Console.WriteLine("\nНомер строки с наименьшей суммой элементов: " + minRow);

        Console.ReadLine();
    }

    static int[,] CreateRandomArray(int m, int n)
    {
        Random random = new Random();
        int[,] array = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(1, 11); // Указываем желаемый диапазон случайных чисел
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        int minSum = int.MaxValue;
        int minRow = -1;

        for (int i = 0; i < m; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRow = i;
            }
        }

        return minRow;
    }
}

