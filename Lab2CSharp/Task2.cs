using System;

namespace ConsoleApplication1
{
    class Task2
    {
        static int[,] Input(out int n, out int m, out int num)
        {
            Console.WriteLine("Введіть число:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static void Change(int[,] a, int num)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] < 0 && a[i, j] % num != 0)
                        a[i, j] = -a[i, j]; // Змінюємо знак
        }

        static void Main()
        {
            int n, m, num; // Оголошуємо num
            int[,] myArray = Input(out n, out m, out num);

            Console.WriteLine("Вихідний масив:");
            Print(myArray);

            Change(myArray, num); // Передаємо num

            Console.WriteLine("Змінений масив:");
            Print(myArray);
        }
    }
}
