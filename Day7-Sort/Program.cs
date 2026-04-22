using System;

class Program
{
    static void BubbleSort(int[] arr)   //BS
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static void SelectionSort(int[] arr)    //SS
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    static void InsertionSort(int[] arr)     //IS
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Choose Sorting Algorithm:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Selection Sort");
        Console.WriteLine("3. Insertion Sort");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("\nEnter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements (space separated):");
        string input = Console.ReadLine();
        string[] values = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(values[i]);
        }
        switch (choice)
        {
            case 1:
                BubbleSort(arr);
                Console.WriteLine("\nSorted using Bubble Sort:");
                break;

            case 2:
                SelectionSort(arr);
                Console.WriteLine("\nSorted using Selection Sort:");
                break;

            case 3:
                InsertionSort(arr);
                Console.WriteLine("\nSorted using Insertion Sort:");
                break;

            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        PrintArray(arr);
    }
}