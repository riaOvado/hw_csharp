using System;
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Task41();
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
    }
}
