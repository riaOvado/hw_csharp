using System;
using System.Linq;
namespace Lesson
{
    class Homework
    {
        static void Main(string[] args)
        {
            //Task47();

            //Console.WriteLine("введите 1 индекс элемента массива ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("введите 2 индекс элемента массива ");
            //int b = int.Parse(Console.ReadLine());
            //Task50(a, b);

            Task52();
        }

        static void Task47()
        {
            //Задача 47.Задайте двумерный массив размером m×n,
            //заполненный случайными вещественными числами.
            //m = 3, n = 4.
            //0,5 7 - 2 - 0,2
            //1 - 3,3 8 - 9,9
            //8 7,8 - 7,1 9
            int m = 3, n = 4;
            double[,] arr = new double [m, n];
            Random rnd = new Random();
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Math.Round(rnd.Next(10) + rnd.NextDouble(), 2);
                    Console.Write(arr[i, j] + " ");
                }
               Console.WriteLine();
            }
        }

        static void Task50(int a, int b)
        {
            //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //17->такого числа в массиве нет
            int[,] arr = { {2, 15, 6, 8 },
                           {5, 0, 14, 3 },
                           {7, 10, 9, 21 } };
            
            if (a < arr.GetLength(0) && b < arr.GetLength(1))
            {
                Console.WriteLine("элемент найден и равен " + arr[a, b] );
            }
            else
            {
                Console.WriteLine("такого элемента нет");
            }
        }

        static void Task52()
        {
            //Задача 52.Задайте двумерный массив из целых чисел.
            //Найдите среднее арифметическое элементов в каждом столбце.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
            int[,] arr = new int[3, 4];
            Random rnd = new Random();
            int sum = 0;
            double res = 0;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for(int j = 0; j < arr.GetLength(1); j++)
            {
                for( int i = 0; i < arr.GetLength(0); i++)
                {
                   sum = sum + arr[i,j];
                }

                res = sum / 3.0;
                Console.Write(res + " ");
                sum = 0;
            }
           
        }
    }
}
