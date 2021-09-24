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
            
            // 1 Задание "Постоянная функция" +
            static void Task1() {
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

            // 2 Алгоритм "Сумма элементов" +
            static void Task2() {
                string path2 = @"..\..\Data2.csv";
                for (int i = 0; i < 2000; i++) {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int sum = 0;
                    for (int j = 1; j <= i; j++) {
                        sum += j;
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path2, time + ";");
                }
            }

            // 3 Задание "Произведение элементов" ?
            static void Task3() {
                string path3 = @"..\..\Data3.csv";
                for (int i = 1; i < 2000; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    int multiplic = 1;
                    stopwatch.Start();
                    for (int j = 1; j <= i; j++)
                    {
                        multiplic = multiplic * j;
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path3, time + ";");
                }
            }

            // 5 Алгоритм "Сортировка пузырьком" +
            static void Task5() {
                string path = @"..\..\Data5.csv";
                int N = 2000;
                List<int> v = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                {
                    int value = rnd.Next(2000);
                    v.Add(value);
                }
                for (int i = 0; i < N; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    int[] nums = new int[i];
                    for (int j = 0; j < i; j++)
                    {
                        nums[j] = j;
                    }
                    stopwatch.Start();
                    for (int j = 0; j < i; j++)
                    {
                        for (int z = 0; z < i-1; z++)
                        {
                            if (nums[z] < nums[z + 1])
                            {
                                int x = nums[z];
                                nums[z] = nums[z + 1];
                                nums[z + 1] = x;
                            }
                        }
                    }
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }
            
            // 6 Алгоритм "Быстрая сортировка"
            static void Task6() {
                static void Quick_Sort(int[] arr, int left, int right) {
                    if (left < right) {
                        int pivot = Partition(arr, left, right);
                        if (pivot > 1) {
                            Quick_Sort(arr, left, pivot - 1);
                        }
                        if (pivot + 1 < right) {
                            Quick_Sort(arr, pivot + 1, right);
                        }
                    }
                }
                static int Partition(int[] arr, int left, int right) {
                    int pivot = arr[left];
                    while (true) {
                        while (arr[left] < pivot) {
                            left++;
                        }
                        while (arr[right] > pivot) {
                            right--;
                        }
                        if (left < right) {
                            if (arr[left] == arr[right]) return right;

                            int temp = arr[left];
                            arr[left] = arr[right];
                            arr[right] = temp;
                        }
                        else {
                            return right;
                        }
                    }
                }
                
                string path = @"..\..\Data6.csv";
                
                int[] arr = new int[2000];
                for (int i = 1; i < 2000; i++) {
                    for (int j = 1; j <= i; j++) {
                        Random rnd = new Random();
                        arr[j] = rnd.Next(1, 2000);
                    }
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Quick_Sort(arr, 0, arr.Length-1);
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }

                
                
            }
            
            Task6();
        }
    }
}