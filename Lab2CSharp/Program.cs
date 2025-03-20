using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nОберіть завдання:");
                Console.WriteLine("1 - Завдання 1");
                Console.WriteLine("2 - Завдання 2");
                Console.WriteLine("3 - Завдання 3");
                Console.WriteLine("4 - Завдання 4");
                Console.WriteLine("5 - Завдання 5");
                Console.WriteLine("0 - Вийти");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1.Run(); break;
                    case "2": Task2.Run(); break;
                    case "3": Task3.Run(); break;
                    case "4": Task4.Run(); break;
                    case "5": Task5.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Некоректний вибір, спробуйте ще раз."); break;
                }
            }
        }
    }

    class Task1
    {
        static int[] Input(out int num)
        {
            Console.WriteLine("Введіть число");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Розмірність масиву");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void Change(int[] a, int num)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0 && a[i] % num != 0) a[i] = -a[i];
        }

        public static void Run()
        {
            int num;
            int[] myArray = Input(out num);
            Console.WriteLine("Вихідний масив:");
            Print(myArray);
            Change(myArray, num);
            Console.WriteLine("Змінений масив:");
            Print(myArray);
        }
    }

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
                        a[i, j] = -a[i, j];
        }

        public static void Run()
        {
            int n, m, num;
            int[,] myArray = Input(out n, out m, out num);
            Console.WriteLine("Вихідний масив:");
            Print(myArray);
            Change(myArray, num);
            Console.WriteLine("Змінений масив:");
            Print(myArray);
        }
    }

    class Task3
    {
        static int[] Input()
        {
            Console.WriteLine("Розмірність масиву:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;
        }

        static void Print(int[] a)
        {
            foreach (var item in a)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }

        static void Change(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0)
                    a[i] = -a[i];
        }

        public static void Run()
        {
            int[] myArray = Input();
            Console.WriteLine("Вихідний масив:");
            Print(myArray);
            Change(myArray);
            Console.WriteLine("Змінений масив:");
            Print(myArray);
        }
    }



    class Task4
    {
        static int[,] Input(out int n)
        {
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
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

        static double FindAverageAboveSecondaryDiagonal(int[,] a, int n)
        {
            double sum = 0;
            int count = 0;

            // Перебір елементів над побічною діагоналлю
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[i, j] != 0)
                    {
                        sum += a[i, j];
                        count++;
                    }
                }
            }

            return count > 0 ? sum / count : 0; // Якщо немає ненульових елементів, повертаємо 0
        }

        public static void Run()
        {
            int n;
            int[,] myArray = Input(out n);

            Console.WriteLine("Вихідний масив:");
            Print(myArray);

            double average = FindAverageAboveSecondaryDiagonal(myArray, n);

            if (average != 0)
                Console.WriteLine($"Середнє арифметичне ненульових елементів над побічною діагоналлю: {average:F2}");
            else
                Console.WriteLine("Немає ненульових елементів над побічною діагоналлю.");
        }
    }
}




class Task5
{
    public static void Run()
    {
        Console.Write("Кількість рядків: ");
        int n = int.Parse(Console.ReadLine());

        int[][] array = new int[n][];
        int maxColumns = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            array[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                array[i][j] = int.Parse(Console.ReadLine());
            }

            if (m > maxColumns) maxColumns = m;
        }

        int[] negativeSums = new int[maxColumns];

        for (int j = 0; j < maxColumns; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (j < array[i].Length && array[i][j] < 0)
                    negativeSums[j] += array[i][j];
            }
        }

        Console.WriteLine("\nСума від’ємних елементів у кожному стовпці:");
        for (int j = 0; j < maxColumns; j++)
            Console.WriteLine($"Стовпець {j + 1}: {negativeSums[j]}");
    }
}
