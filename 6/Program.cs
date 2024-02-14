namespace _6
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            int[][] datasets = GenerateDatasets();
            //int[][] datasets = new int[][] { Enumerable.Range(1, 20000).Reverse().ToArray() };

            foreach (var dataset in datasets)
            {
                Console.WriteLine("Сортування вибором:");
                RunSortingAlgorithmTest(SelectionSort.Sort, StudentSelectionSort.Sort, dataset);

                Console.WriteLine("Шейкерне сортування:");
                RunSortingAlgorithmTest(ShakerSort.Sort, StudentShakerSort.Sort, dataset);
            }

            Console.WriteLine("Тестування завершено.");
            Console.ReadLine();
        }

        static int[][] GenerateDatasets()
        {
            /*Random random = new Random();
            int[][] datasets = new int[5][];

            for (int i = 0; i < datasets.Length; i++)
            {
                int size = random.Next(10000, 20000);
                datasets[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    datasets[i][j] = random.Next(10000);
                }

            }

            return datasets;*/

            int[][] datasets = new int[5][];
            for (int i = 0; i < datasets.Length; i++)
            {
                string line = File.ReadAllLines($"file{i}.txt").First();
                string[] numbers = line.Split(", ");
                datasets[i] = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    datasets[i][j] = int.Parse(numbers[j]);
                }

            }

            return datasets;
        }

        static void RunSortingAlgorithmTest(Func<int[], int[]> etalonSort, Func<int[], int[]> studentSort, int[] dataset)
        {
            int[] copy = new int[dataset.Length];
            Array.Copy(dataset, copy, dataset.Length);

            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] etalonSortedArray = etalonSort(copy);
            stopwatch.Stop();
            long etalonTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            int[] studentSortedArray = studentSort(copy);
            stopwatch.Stop();
            long studentTime = stopwatch.ElapsedMilliseconds;

            bool sortedCorrectly = ArraysAreEqual(etalonSortedArray, studentSortedArray);
            bool timeWithinBounds = IsTimeWithinBounds(etalonTime, studentTime);
            string result = sortedCorrectly && timeWithinBounds ? "Правильно" : "Неправильно";
            Console.WriteLine($"Сортування: {result}. Час студента: {studentTime} мс, час еталону: {etalonTime} мс");

        }

        static bool ArraysAreEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        static bool IsTimeWithinBounds(long etalonTime, long studentTime)
        {
            long lowerBound = Math.Max(0, etalonTime / 5 - 200);
            long upperBound = etalonTime * 5 + 200;

            return studentTime >= lowerBound && studentTime <= upperBound;
        }
    }

    class SelectionSort
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int[] Sort(int[] originalData)
        {
            int[] data = new int[originalData.Length];
            Array.Copy(originalData, data, originalData.Length);
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min_index])
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    Swap(ref data[i], ref data[min_index]);
                }
            }
            return data;
        }
    }

    class ShakerSort
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int[] Sort(int[] originalData)
        {
            int[] data = new int[originalData.Length];
            Array.Copy(originalData, data, originalData.Length);
            for (var i = 0; i < data.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        Swap(ref data[j], ref data[j + 1]);
                        swapFlag = true;
                    }
                }

                for (var j = data.Length - 2 - i; j > i; j--)
                {
                    if (data[j - 1] > data[j])
                    {
                        Swap(ref data[j - 1], ref data[j]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
            return data;
        }
    }

    class StudentSelectionSort
    {
        public static int[] Sort(int[] originalData)
        {
            int[] data = new int[originalData.Length];
            Array.Copy(originalData, data, originalData.Length);
            int n = data.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (data[j] < data[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = data[min_idx];
                data[min_idx] = data[i];
                data[i] = temp;
            }
            return data;
        }
        /*static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Heapify(int[] list, int listLength, int root)
        {
            int largest = root;
            int l = 2 * root + 1;
            int r = 2 * root + 2;

            if (l < listLength && list[l] > list[largest])
                largest = l;

            if (r < listLength && list[r] > list[largest])
                largest = r;

            if (largest != root)
            {
                Swap(ref list[root], ref list[largest]);
                Heapify(list, listLength, largest);
            }
        }
        static void HeapSort(int[] list, int listLength)
        {
            for (int i = listLength / 2 - 1; i >= 0; i--)
                Heapify(list, listLength, i);

            for (int i = listLength - 1; i >= 0; i--)
            {
                Swap(ref list[0], ref list[i]);
                Heapify(list, i, 0);
            }
        }
        public static int[] Sort(int[] originalData)
        {
            // Use int type for indice and int for values in data.
            int[] data = new int[originalData.Length];
            Array.Copy(originalData, data, originalData.Length);
            HeapSort(data, data.Length);
            return data;
        }*/
    }

    class StudentShakerSort
    {
        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static int[] Sort(int[] originalData)
        {
            int[] data = new int[originalData.Length];
            Array.Copy(originalData, data, originalData.Length);
            bool flag = false;
            while (!flag)
            {
                int[] start = { 1, data.Length - 1 };
                int[] end = { data.Length, 0 };
                int[] inc = { 1, -1 };

                for (int it = 0; it < 2; ++it)
                {
                    flag = true;

                    for (int i = start[it]; i != end[it]; i += inc[it])
                    {
                        if (data[i - 1] > data[i])
                        {
                            Swap(ref data[i - 1], ref data[i]);
                            flag = false;
                        }
                    }

                    if (flag)
                        break;
                }
            }
            return data;
        }
    }
}