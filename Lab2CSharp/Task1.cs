namespace ConsoleApplication1
{
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
                if (a[i] < 0 && a[i]% num !=0 ) a[i] = -a[i];
        }
        static void Main()
        {

            int num;
            int[] myArray = Input(out num);
            Console.WriteLine("Вихідний масив:");
            Print(myArray);
            Change(myArray, num);
            Console.WriteLine("Змінений массив:");
            Print(myArray);
        }
    }
}
