/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using System;

class Program
{
    static void Main()
    {
        // Создание трехмерного массива
        int[,,] array = new int[3, 3, 3];

        // Создание объекта Random для генерации случайных чисел
        Random random = new Random();

        // Заполнение массива случайными, неповторяющимися двузначными числами
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int num;
                    bool isUnique;

                    do
                    {
                        num = random.Next(10, 100);
                        isUnique = true;

                        // Проверка на уникальность числа в массиве
                        for (int x = 0; x < 3; x++)
                        {
                            for (int y = 0; y < 3; y++)
                            {
                                for (int z = 0; z < 3; z++)
                                {
                                    if (array[x, y, z] == num)
                                    {
                                        isUnique = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    while (!isUnique);

                    array[i, j, k] = num;
                }
            }
        }

        // Вывод элементов массива и добавление индексов
        Console.WriteLine("Элементы массива с индексами:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Плоскость {0}:", i);
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("{3}	({0}, {1}, {2})", i, j, k, array[i, j, k]);
                }
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
