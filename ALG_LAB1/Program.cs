using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace ALG_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2000;
            List<int> v = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                int value = rnd.Next(2000);
                v.Add(value);
            }

            MatrixMultiply(N);
            // I-1 Задание "Постоянная функция" +
            static void DoTaskI1()
            {
                string path = @"..\..\Data1.csv";
                int N = 2000;

                for (int i = 1; i <= N; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Console.WriteLine("MEOW <3");
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }

            // I-2 Алгоритм "Сумма элементов" +
            static void DoTaskI2(List<int> v)
            {
                string path2 = @"..\..\Data2.csv";
                for (int i = 0; i < 2000; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int sum = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        sum += v[i];
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path2, time + ";");
                }
            }

            // I-3 Алгоритм "Произведение элементов" ?
            static void DoTaskI3(List<int> v)
            {
                string path3 = @"..\..\Data3.csv";
                for (int i = 0; i < 2000; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    int multiplic = 1;
                    stopwatch.Start();
                    for (int j = 1; j <= i; j++)
                    {
                        multiplic = multiplic * v[i];
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path3, time + ";");
                }
            }

            // I-4 Алгоритм "Хуйня какая-то" -

            // I-5 Алгоритм "Bubble sort" +
            static void DoTaskI5(int N, List<int> v)
            {
                string path = @"..\..\Data5.csv";
                for (int i = 0; i < N; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    for (int j = 0; j < i; j++)
                    {
                        for (int z = 0; z < i - 1; z++)
                        {
                            if (v[z] < v[z + 1])
                            {
                                int x = v[z];
                                v[z] = v[z + 1];
                                v[z + 1] = x;
                            }
                        }
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }

            // I-6 Алгоритм "Quick sort" +
            static void DoTaskI6()
            {
                static void Quick_Sort(int[] arr, int left, int right)
                {
                    if (left < right)
                    {
                        int pivot = Partition(arr, left, right);
                        if (pivot > 1)
                        {
                            Quick_Sort(arr, left, pivot - 1);
                        }

                        if (pivot + 1 < right)
                        {
                            Quick_Sort(arr, pivot + 1, right);
                        }
                    }
                }

                static int Partition(int[] arr, int left, int right)
                {
                    int pivot = arr[left];
                    while (true)
                    {
                        while (arr[left] < pivot)
                        {
                            left++;
                        }

                        while (arr[right] > pivot)
                        {
                            right--;
                        }

                        if (left < right)
                        {
                            if (arr[left] == arr[right]) return right;

                            int temp = arr[left];
                            arr[left] = arr[right];
                            arr[right] = temp;
                        }
                        else
                        {
                            return right;
                        }
                    }
                }

                string path = @"..\..\Data6.csv";
                int[] arr = new int[2000];
                for (int i = 1; i < 2000; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Random rnd = new Random();
                        arr[j] = rnd.Next(1, 2000);
                    }

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Quick_Sort(arr, 0, arr.Length - 1);
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }

            // I-7 Алгоритм "Timsort" +
            static void DoTaskI7()
            {
                int[] arr = new int[2000];
                string path7 = @"..\..\Data7.csv";

                for (int i = 1; i < 2000; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    for (int j = 1; j <= i; j++)
                    {
                        Random rnd = new Random();
                        arr[j] = rnd.Next(1, 1000);
                    }
                    int n = arr.Length;

                    //Console.Write("Given Array is\n");
                    //GFG.printArray(arr, n);

                    // Function Call
                    GFG.timSort(arr, n);
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path7, time + ";");

                    //Console.Write("After Sorting Array is\n");
                    //GFG.printArray(arr, n);
                }
            }

            // I-8 Алгоритм "Возведение в степень" ?
            static void DoTaskI8()
            {
                string path8 = @"..\..\Data8.csv";
                int n = 7; // Степень числа
                for (int i = 1; i < 10000; i++)
                { // Лимит
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    decimal c = i;
                    decimal f = 1;
                    int k = n;
                    while (k != 0)
                    {
                        if (k % 2 == 0)
                        {
                            c = c * c;
                            k = k / 2;
                        }
                        else
                        {
                            f = f * c;
                            k = k - 1;
                        }
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path8, time + ";");
                    Console.WriteLine(f);

                }

            }
            //II-Matrix
            static void MatrixMultiply(int N)
            {
                for (int x = 0; x < N; x++)
                {
                    string pathMatrix = @"..\..\DataMatrix.csv";
                    Random rnd = new Random();
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int[,] mas1 = new int[N, N];
                    int[,] mas2 = new int[N, N];
                    for (int i = 0; i < N; i++)
                        for (int j = 0; j < N; j++)
                        {
                            mas1[i, j] = rnd.Next();
                            mas2[i, j] = rnd.Next();
                        }
                    int[,] result = new int[N, N];
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            for (int k = 0; k < N; k++)
                            {
                                result[i, j] += mas1[i, k] * mas2[k, j];
                            }
                        }
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(pathMatrix, time + ";");
                }

                // III-Oleg Алгоритм "Сортировка в двумерном массиве по строке" +
                static void DoTaskOleg()
                {
                    static void print(int[,] mass)
                    {
                        int n = mass.GetLength(0);
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write("\t{0} ", mass[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    string pathOleg = @"..\..\DataOleg.csv";
                    {
                        int p = 200;
                        for (int n = 2; n < p; n++)
                        {
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            int[,] mass = new int[n, n];
                            int[] index = new int[n];
                            int[,] mass1 = new int[n, n];
                            int[] mass1dim = new int[n];
                            int строка = 1; // задаем строку

                            Random rnd = new Random();
                            for (int i = 0; i < n; i++)
                            {
                                index[i] = i;
                                for (int j = 0; j < n; j++)
                                    mass[i, j] = rnd.Next(50);
                            }
                            //Array.Copy(mass, 0, mass1, 0, mass.Length); 
                            //Console.WriteLine("Начальная состояние  ");
                            //print(mass);

                            // Сортировка по заданной строке
                            for (int j = 0; j < n; j++)
                                mass1dim[j] = mass[строка, j];

                            Array.Sort(mass1dim, index);

                            for (int j = 0; j < n; j++)
                                for (int g = 0; g < n; g++)
                                    mass[j, g] = mass1[j, index[g]];

                            //Console.WriteLine("Отсортировано по заданной строке {0}", строка + 1);
                            //print(mass);

                            stopwatch.Stop();
                            string time = (stopwatch.ElapsedTicks).ToString();
                            File.AppendAllText(pathOleg, time + ";");
                        }
                    }
                }
            }
        }
        class GFG
        {
            public const int RUN = 32;

            // This function sorts array from left index to
            // to right index which is of size atmost RUN
            public static void insertionSort(int[] arr, int left, int right)
            {
                for (int i = left + 1; i <= right; i++)
                {
                    int temp = arr[i];
                    int j = i - 1;
                    while (j >= left && arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = temp;
                }
            }

            // merge function merges the sorted runs
            public static void merge(int[] arr, int l, int m, int r)
            {
                // original array is broken in two parts
                // left and right array
                int len1 = m - l + 1, len2 = r - m;
                int[] left = new int[len1];
                int[] right = new int[len2];
                for (int x = 0; x < len1; x++)
                    left[x] = arr[l + x];
                for (int x = 0; x < len2; x++)
                    right[x] = arr[m + 1 + x];

                int i = 0;
                int j = 0;
                int k = l;

                // After comparing, we merge those two array
                // in larger sub array
                while (i < len1 && j < len2)
                {
                    if (left[i] <= right[j])
                    {
                        arr[k] = left[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = right[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of left, if any
                while (i < len1)
                {
                    arr[k] = left[i];
                    k++;
                    i++;
                }

                // Copy remaining element
                // of right, if any
                while (j < len2)
                {
                    arr[k] = right[j];
                    k++;
                    j++;
                }
            }

            // Iterative Timsort function to sort the
            // array[0...n-1] (similar to merge sort)
            public static void timSort(int[] arr, int n)
            {

                // Sort individual subarrays of size RUN
                for (int i = 0; i < n; i += RUN)
                    insertionSort(arr, i,
                                 Math.Min((i + RUN - 1), (n - 1)));

                // Start merging from size RUN (or 32).
                // It will merge
                // to form size 64, then
                // 128, 256 and so on ....
                for (int size = RUN; size < n;
                                         size = 2 * size)
                {

                    // Pick starting point of
                    // left sub array. We
                    // are going to merge
                    // arr[left..left+size-1]
                    // and arr[left+size, left+2*size-1]
                    // After every merge, we increase
                    // left by 2*size
                    for (int left = 0; left < n;
                                          left += 2 * size)
                    {

                        // Find ending point of left sub array
                        // mid+1 is starting point of
                        // right sub array
                        int mid = left + size - 1;
                        int right = Math.Min((left +
                                            2 * size - 1), (n - 1));

                        // Merge sub array arr[left.....mid] &
                        // arr[mid+1....right]
                        if (mid < right)
                            merge(arr, left, mid, right);
                    }
                }
            }

            // Utility function to print the Array
            public static void printArray(int[] arr, int n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(arr[i] + " ");
                Console.Write("\n");
            }

            // Driver program to test above function
        }
    }
}