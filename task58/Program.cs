/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		// Запрос размеров матриц
        Console.Write("Введите количество строк первой матрицы: ");
        int m1 = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов первой матрицы: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Введите количество строк второй матрицы: ");
        int m2 = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов второй матрицы: ");
        int n2 = int.Parse(Console.ReadLine());

        // Проверка возможности умножения матриц
        if (n1 != m2)
        {
            Console.WriteLine("Умножение матриц невозможно!");
            Console.ReadLine();
            return;
        }

        // Создание и заполнение двух матриц случайными числами
        int[,] matrix1 = new int[m1, n1];
        int[,] matrix2 = new int[m2, n2];
        Random random = new Random();

        Console.WriteLine("\nПервая матрица:");
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrix1[i, j] = random.Next(1, 11);
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nВторая матрица:");
        for (int i = 0; i < m2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                matrix2[i, j] = random.Next(1, 11);
                Console.Write(matrix2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Создание матрицы-результата и вычисление произведения двух матриц
        int[,] result = new int[m1, n2];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < n1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Вывод матрицы-результата
        Console.WriteLine("\nРезультат умножения матриц:");
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
