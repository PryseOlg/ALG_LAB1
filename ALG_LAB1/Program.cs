using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace ALG_LAB1 {
    class Program {
        static void Main(string[] args) {
            // I-1 Задание "Постоянная функция" +
            static void DoTaskI1() {
                string path = @"..\..\Data1.csv";
                int N = 2000;

                for (int i = 1; i <= N; i++) {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Console.WriteLine("MEOW <3");
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }

            // I-2 Алгоритм "Сумма элементов" +
            static void DoTaskI2() {
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

            // I-3 Задание "Произведение элементов" ?
            static void DoTaskI3() {
                string path3 = @"..\..\Data3.csv";
                for (int i = 1; i < 2000; i++) {
                    Stopwatch stopwatch = new Stopwatch();
                    int multiplic = 1;
                    stopwatch.Start();
                    for (int j = 1; j <= i; j++) {
                        multiplic = multiplic * j;
                    }

                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path3, time + ";");
                }
            }

            // I-5 Алгоритм "Сортировка пузырьком" +
            static void DoTaskI5() {
                string path = @"..\..\Data5.csv";
                int N = 2000;
                List<int> v = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < N; i++) {
                    int value = rnd.Next(2000);
                    v.Add(value);
                }

                for (int i = 0; i < N; i++) {
                    Stopwatch stopwatch = new Stopwatch();
                    int[] nums = new int[i];
                    for (int j = 0; j < i; j++) {
                        nums[j] = j;
                    }

                    stopwatch.Start();
                    for (int j = 0; j < i; j++) {
                        for (int z = 0; z < i - 1; z++) {
                            if (nums[z] < nums[z + 1]) {
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

            // I-6 Алгоритм "Быстрая сортировка" +
            static void DoTaskI6() {
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
                    Quick_Sort(arr, 0, arr.Length - 1);
                    stopwatch.Stop();
                    string time = (stopwatch.ElapsedTicks).ToString();
                    File.AppendAllText(path, time + ";");
                }
            }



            // 10-1 Алгоритм "Формула сочетания" (Теория вероятности) сука блять не подходит для анализа
            static void DoTaskIII1() {
                static decimal fact(int x) {
                    decimal answer = 1;
                    for (int i = x; i > 1; i--) {
                        answer = answer * i;
                    }

                    return answer;
                }

                string path10_1 = @"..\..\Data10-1.csv";
                int n = 27;
                for (int j = 1; j <= n; j++) {

                    for (int i = 1; i < n; i++) {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        decimal a = fact(n);
                        decimal b = fact(i);
                        decimal c = fact(n - i);
                        b = b * c;
                        a = a / b;
                        stopwatch.Stop();
                        string time = (stopwatch.ElapsedTicks).ToString();
                        File.AppendAllText(path10_1, time + ";");

                    }

                }



            }

            // 10-1 Алгоритм "Сортировка в двумерном массиве"
            static void DoTask10_1() {
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
                 string path10_1 = @"..\..\Data10-1.csv";
                 {
                     int p = 200;
                     for (int n = 2; n < p; n++) {
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
                         // Сортировка по заданной строке
                         for (int j = 0; j < n; j++)
                             mass1dim[j] = mass[строка, j];
 
                         Array.Sort(mass1dim ,index );   
 
                         for (int j = 0; j < n  ; j++)
                         for (int g = 0; g < n; g++)
                             mass[j , g] = mass1[j , index[g]];
 
                         
                         stopwatch.Stop();
                         string time = (stopwatch.ElapsedTicks).ToString();
                         File.AppendAllText(path10_1, time + ";");
                     }
                 }
            }
            
            DoTask10_1();
        }
    }
}