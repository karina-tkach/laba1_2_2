namespace _2
{
    using System;

    class Program
    {
        delegate bool FilterDelegate(int value, int k);

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Введіть кратне число k:");
            int k = int.Parse(Console.ReadLine());

            FilterDelegate filterDelegate = IsMultiple;
            bool isRunning = true;
            int[] filteredArray;

            while (isRunning)
            {
                Console.WriteLine("Виберіть метод фільтрації:");
                Console.WriteLine("1. Використання методу Where класу Enumerable.");
                Console.WriteLine("2. Власна реалізація з if та new[].");
                Console.WriteLine("Щоб вийти введіть 0.");
                int methodChoice = int.Parse(Console.ReadLine());

                switch (methodChoice)
                {
                    case 1:
                        filteredArray = FilterArrayUsingWhere(array, k, filterDelegate);
                        break;
                    case 2:
                        filteredArray = FilterArrayCustomImplementation(array, k, filterDelegate);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір методу.");
                        continue;
                }

                Console.WriteLine("Результат:");
                foreach (var item in filteredArray)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static bool IsMultiple(int value, int k)
        {
            return value % k == 0;
        }

        static int[] FilterArrayCustomImplementation(int[] array, int k, FilterDelegate filter)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filter(array[i], k))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filter(array[i], k))
                {
                    result[index++] = array[i];
                }
            }

            return result;
        }

        static int[] FilterArrayUsingWhere(int[] array, int k, FilterDelegate filter)
        {
            return array.Where(x => filter(x, k)).ToArray();
        }
    }

}