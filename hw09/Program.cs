using System;
namespace Les
{
    class Work
    {
        static void Main(string[] args)
        {
            //int n = 0;
            //Console.WriteLine("введите максимальное число промежутка, целочисленное ");
            //try { n = int.Parse(Console.ReadLine()); }catch(Exception) { Console.WriteLine("целочисленное число"); }
            //Console.WriteLine(Task64(n));

            //Task66();

            int n = 0, m = 0;
            Console.WriteLine("введите n ");
            try { 
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("введите m ");
                m = int.Parse(Console.ReadLine());
            } catch (Exception) { Console.WriteLine("целочисленное число"); }
            Console.WriteLine(Task68(n, m));

        }

        static int Task64(int n)
        {
            if (n > 1)
            {
                Console.WriteLine(n + " ");
                return Task64(n-1);
            }
            return n;

            //Задача 64: Задайте значение N.Напишите программу, которая выведет все
            //натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
            //N = 5-> "5, 4, 3, 2, 1"
            //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"
        }
        static void Task66()
        {
            //Задача 66: Задайте значения M и N.Напишите программу,
            //которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15-> 120
            //M = 4; N = 8. -> 30
            int m = 0, n = 0, sum = 0;
            try
            {
                Console.WriteLine("введите промежуток для подсчета суммы, от м ..до.. n включительно!!!");
                Console.WriteLine("введите целочисленное значение m ");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("введите целочисленное значение n ");
                n = int.Parse(Console.ReadLine());
            }
            catch(Exception) {
                Console.WriteLine("значения должны быть целочисленными");
                Environment.Exit(0);
            }
            for(int i = m; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("значение суммы = " + sum);
        }

        static int Task68(int n, int m)
        {
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            //Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(m, n) = 9
            //m = 3, n = 2->A(m, n) = 29
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return Task68(n - 1, 1);
            else
                return Task68(n - 1, Task68(n, m - 1));
        }
    }
}
