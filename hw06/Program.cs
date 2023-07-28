using System;
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task41();
            Task43();
        }

        static void Task41() {
            //Задача 41: Пользователь вводит с клавиатуры M чисел. 
            //Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //0, 7, 8, -2, -2-> 2
            Console.WriteLine("введите кол-во элементов массива");
            int m = int.Parse(Console.ReadLine());
            int[] arr = new int[m];
            int kolvo = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("введите " + (i+1) + " элемент массива ");
                arr[i] = int.Parse(Console.ReadLine());
                if(arr[i] > 0)
                {
                    kolvo++;
                }

            }
            Console.WriteLine("чисел больше нуля - " + kolvo);
        }

        static void Task43()
        {
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
            //задаются пользователем.
            int x = 0,y = 0,b1 = 0,b2 = 0,k1 = 0,k2 = 0;
            Console.WriteLine("введите b1");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите b2");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите k1");
            k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите k2");
            k2 = int.Parse(Console.ReadLine());
            x = (b2-b1)/(k1-k2);
            y = k1 * x + b1;
            Console.WriteLine("координаты " + x + y);
        }
    }
}
