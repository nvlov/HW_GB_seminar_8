/*Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
        Console.WriteLine("\nИсходный массив:");
        PrintArray(array);

        // Упорядочивание элементов каждой строки по убыванию
        SortRowsDescending(array);

        // Вывод упорядоченного массива
        Console.WriteLine("\nУпорядоченный массив:");
        PrintArray(array);

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
            array[i, j] = random.Next(-33, 33); // задаем min и max диапазона случайных чисел
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

    static void SortRowsDescending(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            // Создаем временный массив для сортировки текущей строки
            int[] temp = new int[n];
            for (int j = 0; j < n; j++)
            {
                temp[j] = array[i, j];
            }

            // Сортировка временного массива
            Array.Sort(temp);
            Array.Reverse(temp);

            // Копируем отсортированные элементы обратно в исходный массив
            for (int j = 0; j < n; j++)
            {
                array[i, j] = temp[j];
            }
        }
    }
}