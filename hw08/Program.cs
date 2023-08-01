using System;
using System.Drawing;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task54();
            //Task56();
            //Task58();
            Task60();


        }

        static void PrintArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void FillArray(int[,] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(15);
                }  
            }
        }


        static void Task54()
        {
            //Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по
            //убыванию элементы каждой строки двумерного массива.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //В итоге получается вот такой массив:
            //7 4 2 1
            //9 5 3 2
            //8 4 4 2
            int[,] matrix = new int[3, 3];
            FillArray(matrix);
            Console.WriteLine("массив до сортировки");
            PrintArray(matrix);
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1]) 
                        {
                            int min = 0;
                            min = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = min;
                        }
                    }
                }
            }
            Console.WriteLine("массив после сортировки");
            PrintArray(matrix);
        }

        static void Task56()
        {
            //Задача 56: Задайте прямоугольный двумерный массив.
            //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //5 2 6 7
            //Программа считает сумму элементов в каждой строке и выдаёт
            //номер строки с наименьшей суммой элементов: 1 строка
            int[,] matrix = new int[4, 3];
            int sum = 0, minSum = 10000, numStrok = 0;

            FillArray(matrix);
            Console.WriteLine("изначальный массив");
            PrintArray(matrix);

            int i = 0; 
            while (i < matrix.GetLength(0))
            {
                for(int j = 0; j < matrix.GetLength(1) ; j++)
                {
                    sum+=matrix[i, j];
                }
                if(sum < minSum)
                {
                    minSum = sum;
                    numStrok = i;
                }
                sum = 0;
                i++;
            }
            Console.WriteLine("min sum = " + minSum + "\nномер строки " + (numStrok + 1));
        }

        static void Task58()
        {
            //            Задача 58: Задайте две матрицы.Напишите программу,
            //            которая будет находить произведение двух матриц.
            //            Например, даны 2 матрицы:
            //            2 4 | 3 4
            //            3 2 | 3 3
            //            Результирующая матрица будет:
            //            18 20
            //           5 18
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];

            FillArray(a);
            Console.WriteLine("матрица 1 ");
            PrintArray(a);
            FillArray(b);
            Console.WriteLine("матрица 2");
            PrintArray(b);

                        
            for (int m = 0; m < 2; m++)
            {
                for (int n = 0; n < c.GetLength(0) ; n++)
                {
                    for(int k = 0; k < 2 ; k++)
                    {
                        c[m, n] = c[m, n] + a[m, k] * b[k, n];
                    } 
                }
            }
            Console.WriteLine("произведение: ");
            PrintArray(c);
        }

        static void Task60()
        {
            //Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            //Массив размером 2 x 2 x 2
            //66(0, 0, 0) 25(0, 1, 0)
            //34(1, 0, 0) 41(1, 1, 0)
            //27(0, 0, 1) 90(0, 1, 1)
            //26(1, 0, 1) 55(1, 1, 1)
            int[,,] arr = new int[2, 2, 2];
            int[] h = new int[arr.Length];

           for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = new Random().Next(10,99);
                        for(int l = 0; l < h.Length; l++)
                        {
                           h[i] = arr[i, j, k];
                        }
                        Console.WriteLine( arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
           
        }

    }
}
