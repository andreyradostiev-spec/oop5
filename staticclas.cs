using System;

static class MyMath
{
    // Прості числа (решето Ератосфена)
    public static void PrimeNumbers()
    {
        bool[] prime = new bool[200];

        for (int i = 2; i < 200; i++)
            prime[i] = true;

        for (int p = 2; p * p < 200; p++)
        {
            if (prime[p])
            {
                for (int j = p * p; j < 200; j += p)
                    prime[j] = false;
            }
        }

        Console.WriteLine("Прості числа від 101 до 199:");

        for (int i = 101; i <= 199; i++)
        {
            if (prime[i])
                Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    // Масив дійсних чисел
    public static void RandomArray()
    {
        Random rnd = new Random();

        double[] arr = new double[20];

        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.NextDouble();

        Array.Sort(arr);

        Console.WriteLine("\nВідсортований масив:");

        foreach (double x in arr)
            Console.Write($"{x:F3} ");

        Console.WriteLine();
        Console.WriteLine($"Min = {arr[0]:F3}");
        Console.WriteLine($"Max = {arr[arr.Length - 1]:F3}");
    }

    // Двійковий пошук
    public static void BinarySearchDemo()
    {
        int[] arr = new int[100];

        for (int i = 0; i < 100; i++)
            arr[i] = i + 1;

        Console.Write("Введіть число: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int pos = Array.BinarySearch(arr, key);

        if (pos >= 0)
            Console.WriteLine($"Знайдено на позиції {pos}");
        else
            Console.WriteLine("Елемент не знайдено");
    }
}